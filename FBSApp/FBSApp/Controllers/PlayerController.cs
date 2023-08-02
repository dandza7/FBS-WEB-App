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
        /// [User, Admin] Gets players in list view
        /// </summary>
        [HttpPost(Name = "GetPlayersListed")]
        [Authorize(Roles = "ADMIN, USER")]
        public ActionResult<PaginationWrapper<PlayerListPreviewDTO>> GetPlayersListed([FromBody] PlayerFilterQuery query)
        {
            return Ok(_playerService.GetListed(query));
        }
    }
}
