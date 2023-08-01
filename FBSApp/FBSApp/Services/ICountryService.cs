using FBSApp.Models.DTOs.Country;

namespace FBSApp.Services
{
    public interface ICountryService
    {
        IEnumerable<CountryPreviewDTO> GetAll();
    }
}
