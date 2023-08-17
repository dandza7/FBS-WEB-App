using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Services
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<TeamListPreviewDTO> GetFiltered(TeamFilterQuery query)
        {
            var teams = _unitOfWork.TeamRepository.GetAll(t => t.Country).Where(t => t.Name.Contains(query.Name));
            if (query.CountryId != 0)
            {
                teams = teams.Where(t => t.CountryId == query.CountryId);
            }
            var count = teams.Count();
            List<TeamListPreviewDTO> teamsList = new List<TeamListPreviewDTO>();
            if (query.IsOrderAscending)
            {
                teamsList = _mapper.Map<List<TeamListPreviewDTO>>(teams.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                teamsList = _mapper.Map<List<TeamListPreviewDTO>>(teams.OrderByDescending(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            return new PaginationWrapper<TeamListPreviewDTO>
            {
                TotalCount = count,
                Entities = teamsList
            };
        }

        public PaginationWrapper<MatchListPreviewDTO> GetMatchesByTeam(long teamId, long seasonId, int page, int pageSize)
        {
            if (!_unitOfWork.TeamRepository.GetAll().Any(t => t.Id == teamId))
            {
                throw new NotFoundException($"Team with ID {teamId} does not exist.");
            }
            var matchesRaw = _unitOfWork.MatchRepository.GetAll(m => m.Season)
                                                    .Include(m => m.MatchActors).ThenInclude(ma => ma.Team).ThenInclude(t => t.Country)
                                                    .Include(m => m.PlayersEvidention.Where(pe => pe.Goals.Any())).ThenInclude(pm => pm.Goals)
                                                    .Where(m => seasonId == 0 ? true : m.SeasonId == seasonId)
                                                    .Where(m => m.MatchActors.Where(ma => ma.TeamId == teamId).Any())
                                                    .OrderByDescending(m => m.Date);
            var totalCount = matchesRaw.Count();
            var matches = matchesRaw.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationWrapper<MatchListPreviewDTO>
            {
                Entities = matches.Select(m => new MatchListPreviewDTO
                {
                    Id = m.Id,
                    Date = m.Date,
                    HomeTeamGoals = CalculateTeamGoals(m, "home"),
                    AwayTeamGoals = CalculateTeamGoals(m, "away"),
                    HomeTeam = _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Where(ma => ma.IsTeamHost).First().Team),
                    AwayTeam = _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Where(ma => !ma.IsTeamHost).First().Team),
                    Gameweek = m.Gameweek
                }),
                TotalCount = totalCount
            };
        }

        public IEnumerable<TeamListPreviewDTO> GetListed()
        {
            return _mapper.Map<IEnumerable<TeamListPreviewDTO>>(_unitOfWork.TeamRepository.GetAll(t => t.Country).OrderBy(t => t.Name));
        }

        public TeamDetailedDTO GetTeamDetailed(long teamId)
        {
            var team = _unitOfWork.TeamRepository.GetAll(t => t.Country)
                                                .Include(t => t.Stadium).ThenInclude(s => s.Address).ThenInclude(a => a.Country)
                                                .Include(t => t.Seasons).ThenInclude(s => s.League)
                                                .FirstOrDefault(t => t.Id == teamId);
            if (team == null)
            {
                throw new NotFoundException($"Team with ID {teamId} does not exist.");
            }
            return new TeamDetailedDTO
            {
                Id = team.Id,
                Name = team.Name,
                Logo = team.Logo,
                Flag = team.Country.Flag,
                StadiumName = team.Stadium.Name,
                StadiumAddress = $"{team.Stadium.Address.Street}{(team.Stadium.Address.Number != null ? " " + team.Stadium.Address.Number : "")}, {team.Stadium.Address.Country.Name}",
                Seasons = _mapper.Map<IEnumerable<SeasonDTO>>(team.Seasons),
            };
        }

        public IEnumerable<PlayerListPreviewDTO> GetTeamsSquad(long teamId, long seasonId)
        {
            var team = _unitOfWork.TeamRepository.GetAll(t => t.Seasons).FirstOrDefault(t => t.Id == teamId);
            if (team == null)
            {
                throw new NotFoundException($"Team with ID {teamId} does not exist.");
            }
            if (!team.Seasons.Any(s => s.Id == seasonId))
            {
                throw new NotFoundException($"There is no squad for team '{team.Name}', because it didn't play season with ID {seasonId}");
            }
            var season = _unitOfWork.SeasonRepository.GetAll().FirstOrDefault(s => s.Id == seasonId);
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var teamEngagements = _unitOfWork.TeamEngagementRepository.GetAll()
                                             .Where(te => !((season.StartDate < te.StartDate && season.EndDate < te.StartDate)
                                                         || (season.StartDate > te.EndDate && season.EndDate > te.EndDate))
                                                         && te.TeamId == teamId)
                                             .Include(te => te.Player).ThenInclude(p => p.Country);
            var retVal = new List<PlayerListPreviewDTO>();
            foreach (var te in teamEngagements)
            {
                if (!retVal.Any(p => p.Id == te.PlayerId))
                {
                    retVal.Add(new PlayerListPreviewDTO
                    {
                        Id = te.PlayerId,
                        Name = te.Player.Name,
                        Position = te.Player.Position,
                        Photo = te.Player.Photo,
                        CountryName = te.Player.Country.Name,
                        CountryId = te.Player.Country.Id,
                        CountryFlag = te.Player.Country.Flag,
                        BirthDate = te.Player.BirthDate,
                    });
                }
            }
            return retVal;
        }

        public IEnumerable<HeadStaffDTO> GetTeamsStaff(long teamId, long seasonId)
        {
            var team = _unitOfWork.TeamRepository.GetAll(t => t.Seasons).FirstOrDefault(t => t.Id == teamId);
            if (team == null)
            {
                throw new NotFoundException($"Team with ID {teamId} does not exist.");
            }
            if (!team.Seasons.Any(s => s.Id == seasonId))
            {
                throw new NotFoundException($"There is no staff for team '{team.Name}', because it didn't play season with ID {seasonId}");
            }
            var season = _unitOfWork.SeasonRepository.GetAll().FirstOrDefault(s => s.Id == seasonId);
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var teamEmployments = _unitOfWork.TeamEmploymentRepository.GetAll()
                                             .Where(te => !((season.StartDate < te.StartDate && season.EndDate < te.StartDate)
                                                         || (season.StartDate > te.EndDate && season.EndDate > te.EndDate))
                                                         && te.TeamId == teamId && te.Staff.Boss == null)
                                             .Include(te => te.Staff).ThenInclude(p => p.Country).ToList();
            return teamEmployments.Select(te => new HeadStaffDTO
            {
                Staff = new StaffDTO { Id = te.Staff.Id, BirthDate = te.Staff.BirthDate, Name = te.Staff.Name, CountryFlag = te.Staff.Country.Flag },
                StartOfEmployment = te.StartDate,
                EndOfEmployment = te.EndDate,
                Empolyees = MakeStaffHierarchy(te, season)
            });
        }

        private IEnumerable<StaffEmployeeDTO> MakeStaffHierarchy(TeamEmployment employment, Season season)
        {
            var employments = _unitOfWork.TeamEmploymentRepository.GetAll().Include(te => te.Staff).ThenInclude(s => s.Country)
                                                                           .Include(te => te.Staff).ThenInclude(s => s.Employments)
                                                   .Where(te => te.Staff.BossId == employment.Staff.Id)
                                                   .Where(te => te.Staff.Employments.Where(e => !((employment.StartDate <= e.StartDate && employment.EndDate <= e.StartDate)
                                                                                   || (employment.StartDate >= e.EndDate && employment.EndDate >= e.EndDate))
                                                                                   && !((season.StartDate <= e.StartDate && season.EndDate <= e.StartDate)
                                                                                   || (season.StartDate >= e.EndDate && season.EndDate >= e.EndDate))).Any()).ToList();
            var x = 1;
            return employments.Select(e => new StaffEmployeeDTO
            {
                Staff = new StaffDTO { Id = e.Staff.Id, BirthDate = e.Staff.BirthDate, Name = e.Staff.Name, CountryFlag = e.Staff.Country.Flag },
                Empolyees = MakeStaffHierarchy(e, season)
            });

        }

        private int CalculateTeamGoals(Match match, string teamtype = "home")
        {
            var team = match.MatchActors.First(ma => ma.IsTeamHost == (teamtype == "home")).Team;

            var goals = 0;

            foreach (var pe in match.PlayersEvidention)
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
