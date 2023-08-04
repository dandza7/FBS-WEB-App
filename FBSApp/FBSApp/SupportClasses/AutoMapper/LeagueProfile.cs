using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.League;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class LeagueProfile : Profile
    {
        public LeagueProfile()
        {
            CreateMap<League, LeagueDTO>();
            CreateMap<NewLeagueDTO, League>();
        }
    }
}
