using FBSApp.Models;
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
        void SaveChanges();
    }
}
