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

        public void SaveChanges()
        {
            _FBS_DB_Context.SaveChanges();
        }
    }
}
