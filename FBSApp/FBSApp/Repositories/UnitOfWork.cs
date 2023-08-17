using FBSApp.Models;
using FBSApp.Repository;
using FSBApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _FBS_DB_Context;
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Country> _countryRepository;
        private IGenericRepository<Address> _addressRepository;
        private IGenericRepository<Stadium> _stadiumRepository;
        private IGenericRepository<Team> _teamRepository;
        private IGenericRepository<Player> _playerRepository;
        private IGenericRepository<League> _leagueRepository;
        private IGenericRepository<Season> _seasonRepository;
        private IGenericRepository<Match> _matchRepository;
        private IGenericRepository<MatchActor> _matchActorRepository;
        private IGenericRepository<TeamEngagement> _teamEngagementRepository;
        private IGenericRepository<Staff> _staffRepository;
        private IGenericRepository<TeamEmployment> _teamEmploymentRepository;
        private IGenericRepository<Award> _awardRepository;
        private IGenericRepository<TeamStats> _teamStatsRepository;
        private IGenericRepository<PlayedMatch> _playedMatchRepository;
        private IGenericRepository<Goal> _goalRepository;
        public UnitOfWork(DbContext FBS_DB_Context)
        {
            _FBS_DB_Context = FBS_DB_Context;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                _userRepository ??= new GenericRepository<User>(_FBS_DB_Context);
                return _userRepository;
            }
        }
        public IGenericRepository<Country> CountryRepository
        {
            get
            {
                _countryRepository ??= new GenericRepository<Country>(_FBS_DB_Context);
                return _countryRepository;
            }
        }
        public IGenericRepository<Address> AddressRepository
        {
            get
            {
                _addressRepository ??= new GenericRepository<Address>(_FBS_DB_Context);
                return _addressRepository;
            }
        }
        public IGenericRepository<Stadium> StadiumRepository
        {
            get
            {
                _stadiumRepository ??= new GenericRepository<Stadium>(_FBS_DB_Context);
                return _stadiumRepository;
            }
        }
        public IGenericRepository<Team> TeamRepository
        {
            get
            {
                _teamRepository ??= new GenericRepository<Team>(_FBS_DB_Context);
                return _teamRepository;
            }
        }
        public IGenericRepository<Player> PlayerRepository
        {
            get
            {
                _playerRepository ??= new GenericRepository<Player>(_FBS_DB_Context);
                return _playerRepository;
            }
        }
        public IGenericRepository<League> LeagueRepository
        {
            get
            {
                _leagueRepository ??= new GenericRepository<League>(_FBS_DB_Context);
                return _leagueRepository;
            }
        }
        public IGenericRepository<Season> SeasonRepository
        {
            get
            {
                _seasonRepository ??= new GenericRepository<Season>(_FBS_DB_Context);
                return _seasonRepository;
            }
        }
        public IGenericRepository<Match> MatchRepository
        {
            get
            {
                _matchRepository ??= new GenericRepository<Match>(_FBS_DB_Context);
                return _matchRepository;
            }
        }
        public IGenericRepository<MatchActor> MatchActorRepository
        {
            get
            {
                _matchActorRepository ??= new GenericRepository<MatchActor>(_FBS_DB_Context);
                return _matchActorRepository;
            }
        }
        public IGenericRepository<TeamEngagement> TeamEngagementRepository
        {
            get
            {
                _teamEngagementRepository ??= new GenericRepository<TeamEngagement>(_FBS_DB_Context);
                return _teamEngagementRepository;
            }
        }
        public IGenericRepository<Staff> StaffRepository
        {
            get
            {
                _staffRepository ??= new GenericRepository<Staff>(_FBS_DB_Context);
                return _staffRepository;
            }
        }
        public IGenericRepository<TeamEmployment> TeamEmploymentRepository
        {
            get
            {
                _teamEmploymentRepository ??= new GenericRepository<TeamEmployment>(_FBS_DB_Context);
                return _teamEmploymentRepository;
            }
        }
        public IGenericRepository<Award> AwardRepository
        {
            get
            {
                _awardRepository ??= new GenericRepository<Award>(_FBS_DB_Context);
                return _awardRepository;
            }
        }
        public IGenericRepository<TeamStats> TeamStatsRepository
        {
            get
            {
                _teamStatsRepository ??= new GenericRepository<TeamStats>(_FBS_DB_Context);
                return _teamStatsRepository;
            }
        }
        public IGenericRepository<PlayedMatch> PlayedMatchRepository
        {
            get
            {
                _playedMatchRepository ??= new GenericRepository<PlayedMatch>(_FBS_DB_Context);
                return _playedMatchRepository;
            }
        }
        public IGenericRepository<Goal> GoalRepository
        {
            get
            {
                _goalRepository ??= new GenericRepository<Goal>(_FBS_DB_Context);
                return _goalRepository;
            }
        }

        public void SaveChanges()
        {
            _FBS_DB_Context.SaveChanges();
        }
    }
}
