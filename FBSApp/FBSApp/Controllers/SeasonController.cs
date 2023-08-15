using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Team;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/seasons")]
    public class SeasonController : ControllerBase
    {
        private readonly ISeasonService _seasonService;
        public SeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }

        /// <summary>
        /// [Anonymous] Gets all seasons by league
        /// </summary>
        [HttpGet("{id}", Name = "GetAllSeasons")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<SeasonDTO>> GetAllSeasons(long id)
        {
            return Ok(_seasonService.GetAll(id));
        }

        /// <summary>
        /// [Admin] Creates new season
        /// </summary>
        [HttpPost(Name = "CreateNewSeason")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<long> CreateNewSeason([FromBody] NewSeasonDTO newSeason)
        {
            return Ok(_seasonService.Create(newSeason));
        }

        /// <summary>
        /// [Admin] Gets teams in season
        /// </summary>
        [HttpGet("{id}/teams", Name = "GetTeamsInSeason")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<IEnumerable<TeamListPreviewDTO>> GetTeamsInSeason(long id)
        {
            return Ok(_seasonService.GetTeamsInSeason(id));
        }

        /// <summary>
        /// [Anonymous] Gets matches in season
        /// </summary>
        [HttpGet("{id}/matches/{page}/{pageSize}", Name = "GetMatchesInSeason")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<MatchListPreviewDTO>> GetMatchesInSeason(long id, int page, int pageSize)
        {
            return Ok(_seasonService.GetMatchesInSeason(id, page, pageSize));
        }

        /// <summary>
        /// [Anonymous] Gets seasons table
        /// </summary>
        [HttpGet("{seasonId}/table", Name = "GetDefaultTable")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<TeamTableViewDTO>> GetDefaultTable(long seasonId)
        {
            return Ok(_seasonService.GetDefaultTable(seasonId));
        }

        /// <summary>
        /// [Anonymous] Gets seasons table
        /// </summary>
        [HttpPost("{seasonId}/filteredTable", Name = "GetFilteredTable")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<TeamTableViewDTO>> GetFilteredTable(long seasonId, [FromBody] TableCalculationQuery query)
        {
            return Ok(_seasonService.GetFilteredTable(seasonId, query));
        }
    }
}
