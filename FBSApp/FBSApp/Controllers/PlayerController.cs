using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Team;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        /// <summary>
        /// [Anonymous] Gets players in list view
        /// </summary>
        [HttpPost(Name = "GetPlayersListed")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<PlayerListPreviewDTO>> GetPlayersListed([FromBody] PlayerFilterQuery query)
        {
            return Ok(_playerService.GetListed(query));
        }

        /// <summary>
        /// [Anonymous] Gets players team engagements
        /// </summary>
        [HttpGet("{id}/engagements", Name = "GetPlayersEngagements")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<PlayerListPreviewDTO>> GetPlayersEngagements(long id)
        {
            return Ok(_playerService.GetPlayersEngagements(id));
        }

        [HttpGet("temp", Name = "Temp")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> Temp()
        {
            return Ok(_playerService.Temp());
        }

    }
}
