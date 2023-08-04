using FBSApp.Models.DTOs.Season;
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
    }
}
