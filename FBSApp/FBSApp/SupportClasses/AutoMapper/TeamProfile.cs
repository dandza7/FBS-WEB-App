using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamListPreviewDTO>();
        }
    }
}
