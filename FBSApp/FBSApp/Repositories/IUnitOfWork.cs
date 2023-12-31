﻿using FBSApp.Models;
using FSBApp.Repositories;

namespace FBSApp.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Country> CountryRepository { get; }
        IGenericRepository<Address> AddressRepository { get; }
        IGenericRepository<Stadium> StadiumRepository { get; }
        IGenericRepository<Team> TeamRepository { get; }
        IGenericRepository<Player> PlayerRepository { get; }
        IGenericRepository<League> LeagueRepository { get; }
        IGenericRepository<Season> SeasonRepository { get; }
        IGenericRepository<Match> MatchRepository { get; }
        IGenericRepository<MatchActor> MatchActorRepository { get; }
        IGenericRepository<TeamEngagement> TeamEngagementRepository { get; }
        IGenericRepository<Staff> StaffRepository { get; }
        IGenericRepository<TeamEmployment> TeamEmploymentRepository { get; }
        IGenericRepository<Award> AwardRepository { get; }
        IGenericRepository<TeamStats> TeamStatsRepository { get; }
        IGenericRepository<PlayedMatch> PlayedMatchRepository { get; }
        IGenericRepository<Goal> GoalRepository { get; }
        void SaveChanges();
    }
}
