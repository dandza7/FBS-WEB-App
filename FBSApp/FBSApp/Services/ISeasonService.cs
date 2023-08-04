using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface ISeasonService
    {
        IEnumerable<SeasonDTO> GetAll(long leagueId);
        IEnumerable<TeamListPreviewDTO> GetTeamsInSeason(long seasonId);
        long Create(NewSeasonDTO newSeason);
    }
}
