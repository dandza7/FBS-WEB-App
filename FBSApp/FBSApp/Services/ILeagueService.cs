using FBSApp.Models.DTOs.League;

namespace FBSApp.Services
{
    public interface ILeagueService
    {
        IEnumerable<LeagueDTO> GetAll();
        long Create(NewLeagueDTO newLeague);
    }
}
