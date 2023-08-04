using FBSApp.Models.DTOs.League;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/leagues")]
    public class LeagueController : ControllerBase
    {
        private readonly ILeagueService _leagueService;
        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        /// <summary>
        /// [Anonymous] Gets all leagues
        /// </summary>
        [HttpGet(Name = "GetAllLeagues")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<LeagueDTO>> GetAllLeagues()
        {
            return Ok(_leagueService.GetAll());
        }

        /// <summary>
        /// [Admin] Creates new league
        /// </summary>
        [HttpPost(Name = "CreateNewLeague")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<long> CreateNewLeague([FromBody] NewLeagueDTO newLeague)
        {
            return Ok(_leagueService.Create(newLeague));
        }
    }
}
