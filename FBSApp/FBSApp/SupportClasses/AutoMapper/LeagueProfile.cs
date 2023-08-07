using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.League;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class LeagueProfile : Profile
    {
        public LeagueProfile()
        {
            CreateMap<League, LeagueDTO>()
                .ForMember(l => l.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(l => l.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(l => l.Flag, opt => opt.MapFrom(src => src.Country.Flag));
            CreateMap<NewLeagueDTO, League>();
        }
    }
}
