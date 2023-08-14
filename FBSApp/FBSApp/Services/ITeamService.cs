using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;
using FBSApp.Models.DTOs.TeamStats;

namespace FBSApp.Services
{
    public interface ITeamService
    {
        PaginationWrapper<TeamListPreviewDTO> GetListed(TeamFilterQuery query);
        PaginationWrapper<MatchListPreviewDTO> GetMatchesByTeam(long teamId, long seasonId, int page, int pageSize);
        TeamDetailedDTO GetTeamDetailed(long teamId);
        IEnumerable<PlayerListPreviewDTO> GetTeamsSquad(long teamId, long seasonId);
        IEnumerable<HeadStaffDTO> GetTeamsStaff(long teamId, long seasonId);
        TeamStatsDTO GetTeamStats(long id, long seasonId);
    }
}
