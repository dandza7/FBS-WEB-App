using FBSApp.Models.DTOs.League;

namespace FBSApp.Services
{
    public interface ILeagueService
    {
        IEnumerable<LeagueDTO> GetAll();
        LeagueDTO GetById(long id);
        long Create(NewLeagueDTO newLeague);
    }
}
