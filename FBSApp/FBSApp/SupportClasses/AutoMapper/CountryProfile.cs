using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Country;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryPreviewDTO>();
        }
    }
}
