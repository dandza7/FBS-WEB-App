﻿using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Player;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;
using FBSApp.Models.DTOs.TeamStats;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Services
{
    public class MatchService : IMatchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MatchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public MatchSquadDTO GetMatchSquad(long id)
        {
            var match = _unitOfWork.MatchRepository.GetAll().Include(m => m.MatchActors)
                                                            .Include(m => m.PlayersEvidention).ThenInclude(pm => pm.Goals)
                                                            .Include(m => m.PlayersEvidention).ThenInclude(pm => pm.Player).ThenInclude(p => p.Country)
                                                            .FirstOrDefault(m => m.Id == id);


            if (match == null)
            {
                throw new NotFoundException($"Match with ID {id} does not exist!");
            }
            var squads = new MatchSquadDTO();
            InsertStaffIntoSquad(match, squads);
            foreach (var pe in match.PlayersEvidention)
            {
                var homeTeamId = match.MatchActors.Where(ma => ma.IsTeamHost).First().TeamId;
                var awayTeamId = match.MatchActors.Where(ma => !ma.IsTeamHost).First().TeamId;
                InsertPlayerIntoSquad(pe, squads, homeTeamId, awayTeamId, match.Date);
            }
            return squads;
        }

        public MatchStatsDTO GetMatchStats(long id)
        {
            var match = _unitOfWork.MatchRepository.GetAll().Include(m => m.MatchActors).ThenInclude(ma => ma.Stats)
                                                            .FirstOrDefault(m => m.Id == id);
            if (match == null)
            {
                throw new NotFoundException($"Match with ID {id} does not exist!");
            }
            var homeTeamStats = match.MatchActors.First(ma => ma.IsTeamHost).Stats;
            var awayTeamStats = match.MatchActors.First(ma => !ma.IsTeamHost).Stats;
            if (homeTeamStats == null || awayTeamStats == null)
            {
                throw new NotFoundException($"There are no complete stats for match with ID {id}.");
            }
            return new MatchStatsDTO
            {
                HomeTeamStats = new TeamStatsDTO
                {
                    Id = homeTeamStats.Id,
                    Shots = homeTeamStats.Shots,
                    ShotsOnTarget = homeTeamStats.ShotsOnTarget,
                    BlockedShots = homeTeamStats.BlockedShots,
                    ShotsOffTarget = homeTeamStats.Shots - (homeTeamStats.ShotsOnTarget + homeTeamStats.BlockedShots),
                    FreeKicks = homeTeamStats.FreeKicks,
                    CornerKicks = homeTeamStats.CornerKicks,
                    Offsides = homeTeamStats.Offsides,
                    Possession = homeTeamStats.Possession,
                    Saves = homeTeamStats.Saves,
                    Fouls = homeTeamStats.Fouls,
                    RedCards = homeTeamStats.RedCards,
                    YellowCards = homeTeamStats.YellowCards,
                    Tackles = homeTeamStats.Tackles,
                    Passes = homeTeamStats.Passes,
                },
                AwayTeamStats = new TeamStatsDTO
                {
                    Id = awayTeamStats.Id,
                    Shots = awayTeamStats.Shots,
                    ShotsOnTarget = awayTeamStats.ShotsOnTarget,
                    BlockedShots = awayTeamStats.BlockedShots,
                    ShotsOffTarget = awayTeamStats.Shots - (awayTeamStats.ShotsOnTarget + awayTeamStats.BlockedShots),
                    FreeKicks = awayTeamStats.FreeKicks,
                    CornerKicks = awayTeamStats.CornerKicks,
                    Offsides = awayTeamStats.Offsides,
                    Possession = awayTeamStats.Possession,
                    Saves = awayTeamStats.Saves,
                    Fouls = awayTeamStats.Fouls,
                    RedCards = awayTeamStats.RedCards,
                    YellowCards = awayTeamStats.YellowCards,
                    Tackles = awayTeamStats.Tackles,
                    Passes = awayTeamStats.Passes,
                },
            };
        }

        public MatchListPreviewDTO GetOne(long id)
        {
            var match = _unitOfWork.MatchRepository.GetAll().Include(m => m.MatchActors).ThenInclude(ma => ma.Team).ThenInclude(t => t.Country)
                                                            .Include(m => m.PlayersEvidention.Where(pe => pe.Goals.Any())).ThenInclude(pm => pm.Goals)
                                                            .FirstOrDefault(m => m.Id == id);
            if (match == null)
            {
                throw new NotFoundException($"Match with ID {id} does not exist!");
            }
            return new MatchListPreviewDTO
            {
                Id = match.Id,
                Date = match.Date,
                HomeTeamGoals = CalculateTeamGoals(match, "home"),
                AwayTeamGoals = CalculateTeamGoals(match, "away"),
                HomeTeam = _mapper.Map<TeamListPreviewDTO>(match.MatchActors.First(ma => ma.IsTeamHost).Team),
                AwayTeam = _mapper.Map<TeamListPreviewDTO>(match.MatchActors.First(ma => !ma.IsTeamHost).Team),
                Gameweek = match.Gameweek
            };
        }

        private int CalculateTeamGoals(Match match, string teamtype = "home")
        {
            var team = teamtype == "home" ? match.MatchActors.First(ma => ma.IsTeamHost).Team : match.MatchActors.First(ma => !ma.IsTeamHost).Team;

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
        private void InsertStaffIntoSquad(Match match, MatchSquadDTO squad)
        {
            var homeTeamId = match.MatchActors.First(ma => ma.IsTeamHost).TeamId;
            var homeCoach = _unitOfWork.StaffRepository.GetAll(s => s.Country)
                                                          .Where(s => s.BossId == null)
                                                          .Where(s => s.Employments.Where(e => e.TeamId == homeTeamId)
                                                                                   .Where(e => e.StartDate < match.Date && e.EndDate > match.Date).Any()).FirstOrDefault();
            if (homeCoach == null)
            {
                throw new Exception($"ERROR WITH DATA Inserting staff into squad, team with ID {match.MatchActors.Where(ma => ma.IsTeamHost).First().Id} has no head coach at the moment of match with ID {match.Id}.");
            }
            var awayTeamId = match.MatchActors.First(ma => !ma.IsTeamHost).TeamId;
            var awayCoach = _unitOfWork.StaffRepository.GetAll(s => s.Country)
                                                          .Where(s => s.BossId == null)
                                                          .Where(s => s.Employments.Where(e => e.TeamId == awayTeamId)
                                                                                   .Where(e => e.StartDate < match.Date && e.EndDate > match.Date).Any()).FirstOrDefault();
            if (awayCoach == null)
            {
                throw new Exception($"ERROR WITH DATA Inserting staff into squad, team with ID {match.MatchActors.Where(ma => !ma.IsTeamHost).First().Id} has no head coach at the moment of match with ID {match.Id}.");
            }
            squad.HomeHeadCoach = new StaffDTO { Id = homeCoach.Id, BirthDate = homeCoach.BirthDate, Name = homeCoach.Name, CountryFlag = homeCoach.Country.Flag };
            squad.AwayHeadCoach = new StaffDTO { Id = awayCoach.Id, BirthDate = awayCoach.BirthDate, Name = awayCoach.Name, CountryFlag = awayCoach.Country.Flag };
        }
        private void InsertPlayerIntoSquad(PlayedMatch playerEvidention, MatchSquadDTO squad, long homeTeamId, long awayTeamId, DateTime matchDate)
        {
            var teamEngagement = _unitOfWork.TeamEngagementRepository.GetAll().Where(te => te.PlayerId == playerEvidention.PlayerId)
                                                                              .Where(te => te.EndDate > matchDate && te.StartDate < matchDate)
                                                                              .FirstOrDefault();
            if (teamEngagement == null)
            {
                throw new Exception($"ERROR WITH DATA Forming match squad, player with ID {playerEvidention.PlayerId} played a match with ID {playerEvidention.MatchId}, but apparently was a free agent at the time.");
            }
            var player = new PlayerAppearanceDTO
            {
                Id = playerEvidention.PlayerId,
                Name = playerEvidention.Player.Name,
                Flag = playerEvidention.Player.Country.Flag,
                Goals = playerEvidention.Goals.Where(g => !g.IsOwnGoal).Count(),
                OwnGoals = playerEvidention.Goals.Where(g => g.IsOwnGoal).Count(),
                Minutes = playerEvidention.Minutes,
                IsStarter = playerEvidention.IsStarter,
            };
            if (teamEngagement.TeamId == homeTeamId)
            {
                squad.HomeTeam.Add(player);
            }
            else if (teamEngagement.TeamId == awayTeamId)
            {
                squad.AwayTeam.Add(player);
            }
            else
            {
                throw new Exception($"ERROR WITH DATA Forming match squad, player with ID {playerEvidention.PlayerId} played a match with ID {playerEvidention.MatchId}, but apparently was player of team with ID {teamEngagement.TeamId} at the time.");
            }
        }
    }
}
