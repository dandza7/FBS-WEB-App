using FBSApp.Models.DTOs.Country;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/countries")]
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
        [AllowAnonymous]
        public ActionResult<IEnumerable<CountryPreviewDTO>> GetAllCountries()
        {
            return Ok(_countryService.GetAll());
        }
    }
}
