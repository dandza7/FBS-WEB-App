using FBSApp.Models.DTOs.Season;

namespace FBSApp.Services
{
    public interface ISeasonService
    {
        IEnumerable<SeasonDTO> GetAll(long leagueId);
        long Create(NewSeasonDTO newSeason);
    }
}
