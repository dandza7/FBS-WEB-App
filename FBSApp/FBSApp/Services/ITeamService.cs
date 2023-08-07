﻿using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface ITeamService
    {
        public PaginationWrapper<TeamListPreviewDTO> GetListed(TeamFilterQuery query);
        public PaginationWrapper<MatchListPreviewDTO> GetMatchesByTeam(long teamId, int page, int pageSize);
        public TeamDetailedDTO GetTeamDetailed(long teamId);
        public IEnumerable<PlayerListPreviewDTO> GetTeamsSquad(long teamId, long seasonId);
        public IEnumerable<HeadStaffDTO> GetTeamsStaff(long teamId, long seasonId);
    }
}
