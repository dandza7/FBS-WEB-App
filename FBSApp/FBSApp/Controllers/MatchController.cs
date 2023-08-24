using FBSApp.Models.DTOs.Match;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/matches")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        /// <summary>
        /// [Anonymous] Gets one match
        /// </summary>
        [HttpGet("{id}", Name = "GetOne")]
        [AllowAnonymous]
        public ActionResult<MatchListPreviewDTO> GetOne(long id)
        {
            return Ok(_matchService.GetOne(id));
        }

        /// <summary>
        /// [Anonymous] Gets match squad
        /// </summary>
        [HttpGet("{id}/squads", Name = "GetMatchSquad")]
        [AllowAnonymous]
        public ActionResult<MatchSquadDTO> GetMatchSquad(long id)
        {
            return Ok(_matchService.GetMatchSquad(id));
        }

        /// <summary>
        /// [Anonymous] Gets match stats
        /// </summary>
        [HttpGet("{id}/stats", Name = "GetMatchStats")]
        [AllowAnonymous]
        public ActionResult<MatchStatsDTO> GetMatchStats(long id)
        {
            return Ok(_matchService.GetMatchStats(id));
        }
        /// <summary>
        /// [Anonymous] Insert match via CSV file
        /// </summary>
        [HttpPost(Name = "InsertMatch")]
        [AllowAnonymous]
        public ActionResult<long> InsertMatch([FromForm] IFormFileCollection file)
        {
            return Ok(_matchService.InsertMatch(file[0].OpenReadStream()));
        }
    }
}
