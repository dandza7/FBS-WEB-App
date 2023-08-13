using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeasonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewSeasonDTO newSeason)
        {
            if (_unitOfWork.SeasonRepository.GetAll().Where(l => l.Year == newSeason.Year && l.LeagueId == newSeason.LeagueId).Any())
            {
                throw new DuplicateItemException($"Selected league already has season in year(s) {newSeason.Year}");
            }
            var season = _unitOfWork.SeasonRepository.Create(_mapper.Map<Season>(newSeason));
            _unitOfWork.SaveChanges();
            return season.Id;
        }

        public IEnumerable<SeasonDTO> GetAll(long leagueId)
        {
            if (!_unitOfWork.LeagueRepository.GetAll().Where(l => l.Id == leagueId).Any())
            {
                throw new NotFoundException($"League with ID {leagueId} does not exist.");
            }
            return _mapper.Map<IEnumerable<SeasonDTO>>(_unitOfWork.SeasonRepository.GetAll(s => s.League).Where(s => s.LeagueId == leagueId));
        }

        public PaginationWrapper<MatchListPreviewDTO> GetMatchesInSeason(long seasonId, int page, int pageSize)
        {
            if (!_unitOfWork.SeasonRepository.GetAll().Where(s => s.Id == seasonId).Any())
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var matchesRaw = _unitOfWork.MatchRepository.GetAll(m => m.Season)
                                                    .Include(m => m.MatchActors).ThenInclude(ma => ma.Team).ThenInclude(t => t.Country)
                                                    .Where(m => m.SeasonId == seasonId).OrderByDescending(m => m.Date);
            var totalCount = matchesRaw.Count();
            var matches = matchesRaw.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationWrapper<MatchListPreviewDTO>
            {
                Entities = matches.Select(m => new MatchListPreviewDTO
                {
                    Id = m.Id,
                    Date = m.Date,
                    HomeTeamGoals = 0, // TO-DO
                    AwayTeamGoals = 0, // TO-DO
                    HomeTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team),
                    AwayTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team),
                }),
                TotalCount = totalCount
            };
        }

        public IEnumerable<TeamListPreviewDTO> GetTeamsInSeason(long seasonId)
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Include(s => s.Teams).ThenInclude(t => t.Country).Where(s => s.Id == seasonId).FirstOrDefault();
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            return _mapper.Map<List<TeamListPreviewDTO>>(season.Teams.OrderBy(t => t.Name));
        }

        public IEnumerable<TeamTableViewDTO> GetDefaultTable(long seasonId)
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Include(s => s.Teams).ThenInclude(t => t.Country)
                                                              .Include(s => s.Matches).ThenInclude(m => m.MatchActors).ThenInclude(ma => ma.Team)
                                                              .Include(s => s.Matches).ThenInclude(m => m.PlayersEvidention.Where(pe => pe.Goals.Any())).ThenInclude(pm => pm.Goals)
                                                              .Where(s => s.Id == seasonId).FirstOrDefault();
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var teams = season.Teams;
            Dictionary<string, TeamTableViewDTO> table = teams.ToDictionary(t => t.Name, t => new TeamTableViewDTO
            {
                Name = t.Name,
                Logo = t.Logo,
                Flag = t.Country.Flag,
                Wins = 0,
                Draws = 0,
                Losses = 0,
                GoalsScored = 0,
                GoalsConceded = 0,
            });
            var matches = season.Matches.Where(m => m.PlayersEvidention.Any());
            foreach (var match in matches)
            {
                CalculateMatchWinner(match, table);
            }


            return table.Select(t => t.Value).OrderByDescending(t => (3 * t.Wins + t.Draws))
                                             .ThenBy(t => t.Wins + t.Draws + t.Losses)
                                             .ThenByDescending(t => t.GoalsScored - t.GoalsConceded)
                                             .ThenByDescending(t => t.GoalsScored)
                                             .ThenByDescending(t => t.Wins);
        }
        private void CalculateMatchWinner(Match match, Dictionary<string, TeamTableViewDTO> table)
        {
            var homeTeam = match.MatchActors.Where(ma => ma.IsTeamHost).First().Team;
            var awayTeam = match.MatchActors.Where(ma => !ma.IsTeamHost).First().Team;

            var homeGoals = 0;
            var awayGoals = 0;

            foreach (var pe in match.PlayersEvidention)
            {
                var teamName = _unitOfWork.TeamEngagementRepository.GetAll(te => te.Team).Where(te => te.PlayerId == pe.PlayerId)
                                                                                  .Where(te => te.EndDate > match.Date && te.StartDate < match.Date)
                                                                                  .First().Team.Name;
                if (teamName == homeTeam.Name)
                {
                    foreach (var goal in pe.Goals)
                    {
                        if (goal.IsOwnGoal)
                        {
                            awayGoals++;
                        }
                        else
                        {
                            homeGoals++;
                        }
                    }
                }
                else if (teamName == awayTeam.Name)
                {
                    foreach (var goal in pe.Goals)
                    {
                        if (!goal.IsOwnGoal)
                        {
                            awayGoals++;
                        }
                        else
                        {
                            homeGoals++;
                        }
                    }
                }
                else
                {
                    throw new Exception($"ERROR Calculating match winner, player with ID {pe.PlayerId} scored a goal on match with ID {match.Id}, but apparently didn't played for either of team at the time.");
                }
            }
            table[homeTeam.Name].GoalsScored += homeGoals;
            table[homeTeam.Name].GoalsConceded += awayGoals;
            table[awayTeam.Name].GoalsScored += awayGoals;
            table[awayTeam.Name].GoalsConceded += homeGoals;
            if (homeGoals > awayGoals)
            {
                table[homeTeam.Name].Wins++;
                table[awayTeam.Name].Losses++;
            }
            else if (homeGoals < awayGoals)
            {
                table[homeTeam.Name].Losses++;
                table[awayTeam.Name].Wins++;
            }
            else
            {
                table[homeTeam.Name].Draws++;
                table[awayTeam.Name].Draws++;
            }
            return;
        }
    }
}
