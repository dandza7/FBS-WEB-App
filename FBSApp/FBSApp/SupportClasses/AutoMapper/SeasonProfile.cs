using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Season;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class SeasonProfile : Profile
    {
        public SeasonProfile()
        {
            CreateMap<Season, SeasonDTO>()
                .ForMember(s => s.League, opt => opt.MapFrom(s => s.League.Name));
            CreateMap<NewSeasonDTO, Season>();
        }
    }
}
