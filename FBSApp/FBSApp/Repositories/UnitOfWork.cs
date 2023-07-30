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

        public async Task SaveChangesAsync()
        {
            await _FBS_DB_Context.SaveChangesAsync();
        }
    }
}
