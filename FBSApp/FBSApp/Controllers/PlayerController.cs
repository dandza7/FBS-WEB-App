using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Player;
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
        public ActionResult<IEnumerable<TeamEngagementDTO>> GetPlayersEngagements(long id)
        {
            return Ok(_playerService.GetPlayersEngagements(id));
        }

        /// <summary>
        /// [Anonymous] Gets players awards
        /// </summary>
        [HttpGet("{id}/awards", Name = "GetPlayersAwards")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<AwardDTO>> GetPlayersAwards(long id)
        {
            return Ok(_playerService.GetPlayersAwards(id));
        }

        /// <summary>
        /// [Anonymous] Gets player by id
        /// </summary>
        [HttpGet("{id}", Name = "GetPlayer")]
        [AllowAnonymous]
        public ActionResult<PlayerListPreviewDTO> GetPlayer(long id)
        {
            return Ok(_playerService.GetPlayer(id));
        }

        /// <summary>
        /// [Admin] Deletes players engagement
        /// </summary>
        [HttpDelete("{playerId}/engagement/{engagementId}", Name = "DeletePlayersEngagement")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult DeletePlayersEngagement(long playerId, long engagementId)
        {
            _playerService.DeletePlayersEngagement(playerId, engagementId);
            return Ok();
        }

        /// <summary>
        /// [Admin] Creates new player or updates existing one
        /// </summary>
        [HttpPost("update", Name = "CreateOrUpdatePlayer")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<long> CreateOrUpdatePlayer([FromBody] NewPlayerDTO player)
        {
            return Ok(_playerService.CreateOrUpdatePlayer(player));
        }

        /// <summary>
        /// [Admin] Creates new player or updates existing one
        /// </summary>
        [HttpPost("engagement", Name = "AddPlayersEngagement")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult AddPlayersEngagement([FromBody] AddPlayersEngagementDTO engagement)
        {
            _playerService.AddPlayersEngagement(engagement);
            return Ok();
        }

        /// <summary>
        /// [Anonymous] Gets matches played by player
        /// </summary>
        [HttpGet("{id}/matches/{page}/{pageSize}", Name = "GetMatchesByPlayer")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<PlayersMatchDTO>> GetMatchesByPlayer(long id, int page, int pageSize)
        {
            return Ok(_playerService.GetMatchesByPlayer(id, page, pageSize));
        }

        [HttpGet("temp", Name = "Temp")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> Temp()
        {
            return Ok(_playerService.Temp());
        }

    }
}
