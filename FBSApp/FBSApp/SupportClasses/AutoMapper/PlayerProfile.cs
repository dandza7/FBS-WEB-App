using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerListPreviewDTO>()
                .ForMember(p => p.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(p => p.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(p => p.Position, opt => opt.MapFrom(src => src.Position))
                .ForMember(p => p.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(p => p.Photo, opt => opt.MapFrom(src => Convert.ToBase64String(src.Photo)))
                .ForMember(p => p.CountryName, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(p => p.CountryFlag, opt => opt.MapFrom(src => Convert.ToBase64String(src.Country.Flag)));
        }
    }
}
