using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Country;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryPreviewDTO>()
                .ForMember(c => c.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(c => c.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(c => c.Flag, opt => opt.MapFrom(src => Convert.ToBase64String(src.Flag)));
        }
    }
}
