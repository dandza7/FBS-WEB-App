using FBSApp.Models.DTOs.Country;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        /// <summary>
        /// [Anonymous] Gets all countries
        /// </summary>
        [HttpGet(Name = "GetAllCountries")]
        [Authorize(Roles = "ADMIN, USER")]
        public ActionResult<IEnumerable<CountryPreviewDTO>> Login()
        {
            return Ok(_countryService.GetAll());
        }
    }
}
