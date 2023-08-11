using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Staff;

namespace FBSApp.SupportClasses.AutoMapper
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            CreateMap<Staff, StaffDTO>()
                .ForMember(s => s.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(s => s.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(s => s.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(s => s.CountryFlag, opt => opt.MapFrom(src => src.Country.Flag));
        }
    }
}
