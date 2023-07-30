using FBSApp.Models;
using FSBApp.Repositories;

namespace FBSApp.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        void SaveChanges();
    }
}
