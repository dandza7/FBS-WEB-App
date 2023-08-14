using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Award;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class AwardProfile : Profile
    {
        public AwardProfile()
        {
            CreateMap<Award, AwardDTO>()
                .ForMember(a => a.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(a => a.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(a => a.Month, opt => opt.MapFrom(src => src.Month))
                .ForMember(a => a.Season, opt => opt.MapFrom(src => src.Season.Year))
                .ForMember(a => a.League, opt => opt.MapFrom(src => src.Season.League.Name))
                .ForMember(a => a.Type, opt => opt.MapFrom(src => src.Type));
        }
    }
}
