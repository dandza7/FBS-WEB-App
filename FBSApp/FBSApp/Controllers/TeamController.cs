using FBSApp.Models.DTOs;
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
        /// [User, Admin] Gets teams in list view
        /// </summary>
        [HttpPost(Name = "GetTeamsListed")]
        [Authorize(Roles = "ADMIN, USER")]
        public ActionResult<PaginationWrapper<TeamListPreviewDTO>> GetTeamsListed([FromBody] TeamFilterQuery query)
        {
            return Ok(_teamService.GetListed(query));
        }
    }
}
