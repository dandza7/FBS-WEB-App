using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Player;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FBSApp.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlayerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void AddPlayersEngagement(AddPlayersEngagementDTO engagement)
        {
            var player = _unitOfWork.PlayerRepository.GetAll(p => p.Engagements).FirstOrDefault(p => p.Id == engagement.PlayerId);
            if (player == null)
            {
                throw new NotFoundException($"Player with ID {engagement.PlayerId} does not exist.");
            }
            var team = _unitOfWork.TeamRepository.GetAll().FirstOrDefault(p => p.Id == engagement.TeamId);
            if (team == null)
            {
                throw new NotFoundException($"Team with ID {engagement.TeamId} does not exist.");
            }
            if (player.Engagements.Where(e => !(engagement.StartDate > e.EndDate || e.StartDate > engagement.EndDate)).Any())
            {
                throw new DuplicateItemException($"Player with ID {engagement.PlayerId} already has employment in selected period.");
            }
            _unitOfWork.TeamEngagementRepository.Create(new TeamEngagement
            {
                Team = team,
                Player = player,
                StartDate = engagement.StartDate,
                EndDate = engagement.EndDate,
            });
            _unitOfWork.SaveChanges();
        }

        public long CreateOrUpdatePlayer(NewPlayerDTO newPlayerDTO)
        {
            Player? player;
            if (newPlayerDTO.Id != 0)
            {
                player = _unitOfWork.PlayerRepository.GetAll().Where(p => p.Id == newPlayerDTO.Id).FirstOrDefault();
                if (player == null)
                {
                    throw new NotFoundException($"Player with ID {newPlayerDTO.Id} does not exist.");
                }
            }
            else
            {
                player = new Player();
            }
            var country = _unitOfWork.CountryRepository.GetAll().FirstOrDefault(c => c.Id == newPlayerDTO.CountryId);
            if (country == null)
            {
                throw new NotFoundException($"Country with ID {newPlayerDTO.CountryId} does not exist.");
            }
            player.Country = country;
            player.Name = newPlayerDTO.Name;
            player.Photo = newPlayerDTO.Photo.IsNullOrEmpty() ? player.Photo : newPlayerDTO.Photo;
            player.BirthDate = newPlayerDTO.BirthDate;
            player.Position = newPlayerDTO.Position;
            if (newPlayerDTO.Id == 0)
            {
                _unitOfWork.PlayerRepository.Create(player);
            }
            else
            {
                _unitOfWork.PlayerRepository.Update(player);
            }
            _unitOfWork.SaveChanges();
            return player.Id;
        }

        public void DeletePlayersEngagement(long playerId, long engagementId)
        {
            var player = _unitOfWork.PlayerRepository.GetAll(p => p.Engagements).FirstOrDefault(p => p.Id == playerId);
            if (player == null)
            {
                throw new NotFoundException($"Player with ID {playerId} does not exist.");
            }
            var engagement = player.Engagements.Where(e => e.Id == engagementId).FirstOrDefault();
            if (engagement != null)
            {
                DeletePlayerAppearences(engagement);
                _unitOfWork.TeamEngagementRepository.Delete(engagement);
                _unitOfWork.SaveChanges();
            }
        }
        private void DeletePlayerAppearences(TeamEngagement engagement)
        {
            var appearences = _unitOfWork.PlayedMatchRepository.GetAll().Include(pm => pm.Goals)
                                                      .Where(pm => pm.PlayerId == engagement.PlayerId)
                                                      .Where(pm => pm.Match.Date >= engagement.StartDate && pm.Match.Date <= engagement.EndDate)
                                                      .AsNoTracking().ToList();
            foreach (var a in appearences)
            {
                foreach (var g in a.Goals)
                {
                    _unitOfWork.GoalRepository.Delete(g);
                }
                _unitOfWork.PlayedMatchRepository.Delete(a);
            }
        }

        public PaginationWrapper<PlayerListPreviewDTO> GetListed(PlayerFilterQuery query)
        {
            var players = _unitOfWork.PlayerRepository.GetAll(p => p.Country).Where(p => p.Name.Contains(query.Name));
            if (query.CountryId != 0)
            {
                players = players.Where(p => p.CountryId == query.CountryId);
            }
            if (query.Position != "ALL")
            {
                players = players.Where(p => p.Position == query.Position);
            }
            var count = players.Count();
            List<PlayerListPreviewDTO> playersList = new List<PlayerListPreviewDTO>();
            if (query.IsOrderAscending)
            {
                playersList = _mapper.Map<List<PlayerListPreviewDTO>>(players.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                playersList = _mapper.Map<List<PlayerListPreviewDTO>>(players.OrderByDescending(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            return new PaginationWrapper<PlayerListPreviewDTO>
            {
                TotalCount = count,
                Entities = playersList
            };
        }

        public PaginationWrapper<PlayersMatchDTO> GetMatchesByPlayer(long playerId, int page, int pageSize)
        {
            if (!_unitOfWork.PlayerRepository.GetAll().Any(p => p.Id == playerId))
            {
                throw new NotFoundException($"Player with ID {playerId} does not exist.");
            }
            var matchesRaw = _unitOfWork.MatchRepository.GetAll(m => m.Season)
                                                    .Include(m => m.MatchActors).ThenInclude(ma => ma.Team).ThenInclude(t => t.Country)
                                                    .Include(m => m.PlayersEvidention).ThenInclude(pm => pm.Goals)
                                                    .Where(m => m.PlayersEvidention.Where(pe => pe.PlayerId == playerId).Any()).OrderByDescending(m => m.Date);
            var totalCount = matchesRaw.Count();
            var matches = matchesRaw.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationWrapper<PlayersMatchDTO>
            {
                Entities = matches.Select(m => new PlayersMatchDTO
                {
                    Id = m.Id,
                    Date = m.Date,
                    HomeTeamGoals = CalculateTeamGoals(m, "home"),
                    AwayTeamGoals = CalculateTeamGoals(m, "away"),
                    HomeTeam = _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Where(ma => ma.IsTeamHost).First().Team),
                    AwayTeam = _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Where(ma => !ma.IsTeamHost).First().Team),
                    Gameweek = m.Gameweek,
                    Minutes = m.PlayersEvidention.First(pe => pe.PlayerId == playerId).Minutes,
                    Goals = m.PlayersEvidention.First(pe => pe.PlayerId == playerId).Goals.Where(g => !g.IsOwnGoal).Count(),
                    OwnGoals = m.PlayersEvidention.First(pe => pe.PlayerId == playerId).Goals.Where(g => g.IsOwnGoal).Count(),
                    IsStarter = m.PlayersEvidention.First(pe => pe.PlayerId == playerId).IsStarter,
                }),
                TotalCount = totalCount
            };
        }

        public PlayerListPreviewDTO GetPlayer(long playerId)
        {
            var player = _unitOfWork.PlayerRepository.GetAll(p => p.Country).FirstOrDefault(p => p.Id == playerId);
            if (player == null)
            {
                throw new NotFoundException($"Player with ID {playerId} doest not exist!");
            }
            return _mapper.Map<PlayerListPreviewDTO>(player);
        }

        public IEnumerable<AwardDTO> GetPlayersAwards(long playerId)
        {
            if (!_unitOfWork.PlayerRepository.GetAll().Any(p => p.Id == playerId))
            {
                throw new NotFoundException($"Player with ID {playerId} doest not exist!");
            }
            var awards = _unitOfWork.AwardRepository.GetAll().Where(a => a.PlayerId == playerId).Include(a => a.Season).ThenInclude(s => s.League);
            return _mapper.Map<IEnumerable<AwardDTO>>(awards);
        }

        public IEnumerable<TeamEngagementDTO> GetPlayersEngagements(long playerId)
        {
            if (!_unitOfWork.PlayerRepository.GetAll().Any(p => p.Id == playerId))
            {
                throw new NotFoundException($"Player with ID {playerId} does not exist!");
            }
            var teamEngagements = _unitOfWork.TeamEngagementRepository.GetAll().Where(te => te.PlayerId == playerId)
                                                                               .Include(te => te.Team).ThenInclude(t => t.Country);
            return teamEngagements.Select(te => new TeamEngagementDTO
            {
                Id = te.Id,
                Name = te.Team.Name,
                Logo = te.Team.Logo,
                Flag = te.Team.Country.Flag,
                TeamId = te.Team.Id,
                StartDate = te.StartDate,
                EndDate = te.EndDate,
            }).OrderBy(e => e.StartDate);
        }

        public IEnumerable<string> Temp()
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Where(s => s.Id == 1L).FirstOrDefault();
            var players = _unitOfWork.PlayerRepository.GetAll().Where(p => p.Engagements.Where(e => e.StartDate >= DateTime.Parse("Aug 1, 2018") || e.EndDate <= season.EndDate)
                                                                                        .Where(e => e.TeamId == 9).Any())
                                                               .ToList();
            return players.Select(p => $"{p.Id} - {p.Name}");
        }

        private int CalculateTeamGoals(Match match, string teamtype = "home")
        {
            var team = match.MatchActors.First(ma => ma.IsTeamHost == (teamtype == "home")).Team;

            var goals = 0;

            foreach (var pe in match.PlayersEvidention.Where(pe => pe.Goals.Any()))
            {
                var teamEngagement = _unitOfWork.TeamEngagementRepository.GetAll(te => te.Team).Where(te => te.PlayerId == pe.PlayerId)
                                                                                      .Where(te => te.TeamId == team.Id)
                                                                                      .Where(te => te.EndDate > match.Date && te.StartDate < match.Date)
                                                                                      .FirstOrDefault();

                foreach (var goal in pe.Goals)
                {
                    if (teamEngagement == null) // If team engagement is null, it is goal scored by opposing team
                    {
                        if (goal.IsOwnGoal)
                        {
                            goals++;
                        }
                    }
                    else if (teamEngagement.Team.Name == team.Name) // Checking if team engagement is valid
                    {
                        if (!goal.IsOwnGoal)
                        {
                            goals++;
                        }
                    }
                    else // Otherwise there is problem with data in Database
                    {
                        throw new Exception($"ERROR WITH DATA Calculating match winner, player with ID {pe.PlayerId} scored a goal on match with ID {match.Id}, but apparently didn't played for either of team at the time.");
                    }
                }
            }
            return goals;
        }
    }
}
