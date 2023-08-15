using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface ISeasonService
    {
        IEnumerable<SeasonDTO> GetAll(long leagueId);
        IEnumerable<TeamListPreviewDTO> GetTeamsInSeason(long seasonId);
        PaginationWrapper<MatchListPreviewDTO> GetMatchesInSeason(long seasonId, int page, int pageSize);
        long Create(NewSeasonDTO newSeason);
        IEnumerable<TeamTableViewDTO> GetDefaultTable(long seasonId);
        IEnumerable<TeamTableViewDTO> GetFilteredTable(long seasonId, TableCalculationQuery query);
    }
}
