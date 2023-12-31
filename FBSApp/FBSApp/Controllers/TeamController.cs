﻿using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Models.DTOs.Team;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        /// <summary>
        /// [Anonymous] Gets teams filtered
        /// </summary>
        [HttpPost(Name = "GetFiltered")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<TeamListPreviewDTO>> GetFiltered([FromBody] TeamFilterQuery query)
        {
            return Ok(_teamService.GetFiltered(query));
        }

        /// <summary>
        /// [Anonymous] Gets teams in list view
        /// </summary>
        [HttpGet(Name = "GetListed")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<TeamListPreviewDTO>> GetListed()
        {
            return Ok(_teamService.GetListed());
        }

        /// <summary>
        /// [Anonymous] Gets matches by team
        /// </summary>
        [HttpGet("{id}/matches/{seasonId}/{page}/{pageSize}", Name = "GetMatchesByTeam")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<MatchListPreviewDTO>> GetMatchesByTeam(long id, long seasonId, int page, int pageSize)
        {
            return Ok(_teamService.GetMatchesByTeam(id, seasonId, page, pageSize));
        }

        /// <summary>
        /// [Anonymous] Gets team detailed
        /// </summary>
        [HttpGet("{id}/detailed", Name = "GetTeamDetailed")]
        [AllowAnonymous]
        public ActionResult<TeamDetailedDTO> GetTeamDetailed(long id)
        {
            return Ok(_teamService.GetTeamDetailed(id));
        }

        /// <summary>
        /// [Anonymous] Gets teams squad by season
        /// </summary>
        [HttpGet("{id}/squad/{seasonId}", Name = "GetTeamsSquad")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<PlayerListPreviewDTO>> GetTeamsSquad(long id, long seasonId)
        {
            return Ok(_teamService.GetTeamsSquad(id, seasonId));
        }

        /// <summary>
        /// [Anonymous] Gets teams staff by season
        /// </summary>
        [HttpGet("{id}/staff/{seasonId}", Name = "GetTeamsStaff")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<HeadStaffDTO>> GetTeamsStaff(long id, long seasonId)
        {
            return Ok(_teamService.GetTeamsStaff(id, seasonId));
        }
    }
}
