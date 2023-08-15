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
                                                    .Include(m => m.PlayersEvidention.Where(pe => pe.Goals.Any())).ThenInclude(pm => pm.Goals)
                                                    .Where(m => m.SeasonId == seasonId).OrderByDescending(m => m.Date);
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
                    HomeTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team),
                    AwayTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team),
                    Gameweek = m.Gameweek
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

        public IEnumerable<TeamTableViewDTO> GetFilteredTable(long seasonId, TableCalculationQuery query)
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Include(s => s.Teams).ThenInclude(t => t.Country)
                                                              .Include(s => s.Matches.OrderBy(m => m.Date)).ThenInclude(m => m.MatchActors).ThenInclude(ma => ma.Team)
                                                              .Include(s => s.Matches.OrderBy(m => m.Date)).ThenInclude(m => m.PlayersEvidention.Where(pe => pe.Goals.Any())).ThenInclude(pm => pm.Goals)
                                                              .Where(s => s.Id == seasonId).FirstOrDefault();
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var teams = season.Teams;
            var matches = season.Matches.Where(m => m.PlayersEvidention.Any());
            if (query != null)
            {
                if (query.TeamsSubsetFilter != null)
                {
                    teams = teams.Where(t => query.TeamsSubsetFilter.Ids.Contains(t.Id));
                    matches = matches.Where(m => query.TeamsSubsetFilter.Ids.Contains(m.MatchActors.First().TeamId) && query.TeamsSubsetFilter.Ids.Contains(m.MatchActors.Last().TeamId));
                }
                if (query.DateFilter != null)
                {
                    matches = matches.Where(m => query.DateFilter.LowerLimit <= m.Date && m.Date <= query.DateFilter.UpperLimit);
                }
                if (query.GameweeksFilter != null)
                {
                    matches = matches.Where(m => query.GameweeksFilter.LowerLimit <= m.Gameweek && m.Gameweek <= query.GameweeksFilter.UpperLimit);
                }
            }
            Dictionary<string, TeamTableViewDTO> table = teams.ToDictionary(t => t.Name, t => new TeamTableViewDTO
            {
                Name = t.Name,
                //Logo = t.Logo,
                //Flag = t.Country.Flag,
                Wins = 0,
                Draws = 0,
                Losses = 0,
                GoalsScored = 0,
                GoalsConceded = 0,
            });
            foreach (var match in matches)
            {
                CalculateMatchWinner(match, table, query);
            }


            return table.Select(t => t.Value).OrderByDescending(t => (3 * t.Wins + t.Draws))
                                             .ThenBy(t => t.Wins + t.Draws + t.Losses)
                                             .ThenByDescending(t => t.GoalsScored - t.GoalsConceded)
                                             .ThenByDescending(t => t.GoalsScored)
                                             .ThenByDescending(t => t.Wins);
        }

        private bool IsGoalRegularByFilter(Goal goal, TCQ_GoalsMinuteFilter filter)
        {
            if (filter == null)
            {
                return true;
            }
            if (goal.Minute >= 1 && goal.Minute <= 45)
            {
                if (goal.IsExtraTime)
                {
                    return filter.ExtraTimeIncludedFirstHalf;
                }
                if (goal.Minute >= filter.LowerLimitFirstHalf && goal.Minute <= filter.UpperLimitFirstHalf)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (goal.IsExtraTime)
                {
                    return filter.ExtraTimeIncludedSecondHalf;
                }
                if (goal.Minute >= filter.LowerLimitSecondHalf && goal.Minute <= filter.UpperLimitSecondHalf)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckIfTeamExceededGameweekFilterLimit(int playedMatches, TCQ_PlayedGameweeksFilter filter = null)
        {
            return filter == null ? false : playedMatches >= filter.PlayedGameweeks;
        }

        private void CalculateMatchWinner(Match match, Dictionary<string, TeamTableViewDTO> table, TableCalculationQuery filter = null)
        {
            var homeTeam = match.MatchActors.Where(ma => ma.IsTeamHost).First().Team;
            var awayTeam = match.MatchActors.Where(ma => !ma.IsTeamHost).First().Team;

            var homeGoals = 0;
            var awayGoals = 0;

            var goalFilter = filter == null ? null : filter.GoalsMinuteFilter;

            foreach (var pe in match.PlayersEvidention)
            {
                var teamName = _unitOfWork.TeamEngagementRepository.GetAll(te => te.Team).Where(te => te.PlayerId == pe.PlayerId)
                                                                                  .Where(te => te.EndDate > match.Date && te.StartDate < match.Date)
                                                                                  .First().Team.Name;
                if (teamName == homeTeam.Name)
                {
                    foreach (var goal in pe.Goals)
                    {
                        if (IsGoalRegularByFilter(goal, goalFilter))
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
                }
                else
                {
                    foreach (var goal in pe.Goals)
                    {
                        if (IsGoalRegularByFilter(goal, goalFilter))
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
                }
            }

            if (!CheckIfTeamExceededGameweekFilterLimit(table[homeTeam.Name].Wins + table[homeTeam.Name].Draws + table[homeTeam.Name].Losses, filter.PlayedGameweeksFilter))
            {
                table[homeTeam.Name].GoalsScored += homeGoals;
                table[homeTeam.Name].GoalsConceded += awayGoals;
                if (homeGoals > awayGoals)
                {
                    table[homeTeam.Name].Wins++;
                }
                else if (homeGoals < awayGoals)
                {
                    table[homeTeam.Name].Losses++;
                }
                else
                {
                    table[homeTeam.Name].Draws++;
                }
            }
            if (!CheckIfTeamExceededGameweekFilterLimit(table[awayTeam.Name].Wins + table[awayTeam.Name].Draws + table[awayTeam.Name].Losses, filter.PlayedGameweeksFilter))
            {
                table[awayTeam.Name].GoalsScored += awayGoals;
                table[awayTeam.Name].GoalsConceded += homeGoals;
                if (homeGoals > awayGoals)
                {
                    table[awayTeam.Name].Losses++;
                }
                else if (homeGoals < awayGoals)
                {
                    table[awayTeam.Name].Wins++;
                }
                else
                {
                    table[awayTeam.Name].Draws++;
                }
            }
            return;
        }

        private int CalculateTeamGoals(Match match, string teamtype = "home")
        {
            var team = teamtype == "home" ? match.MatchActors.Where(ma => ma.IsTeamHost).First().Team : match.MatchActors.Where(ma => !ma.IsTeamHost).First().Team;

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
