﻿using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface ITeamService
    {
        PaginationWrapper<TeamListPreviewDTO> GetFiltered(TeamFilterQuery query);
        IEnumerable<TeamListPreviewDTO> GetListed();
        PaginationWrapper<MatchListPreviewDTO> GetMatchesByTeam(long teamId, long seasonId, int page, int pageSize);
        TeamDetailedDTO GetTeamDetailed(long teamId);
        IEnumerable<PlayerListPreviewDTO> GetTeamsSquad(long teamId, long seasonId);
        IEnumerable<HeadStaffDTO> GetTeamsStaff(long teamId, long seasonId);
    }
}
