using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamListPreviewDTO>()
                .ForMember(t => t.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(t => t.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(t => t.Logo, opt => opt.MapFrom(src => Convert.ToBase64String(src.Logo)))
                .ForMember(t => t.Flag, opt => opt.MapFrom(src => Convert.ToBase64String(src.Country.Flag)));
        }
    }
}
