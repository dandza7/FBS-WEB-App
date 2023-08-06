using AutoMapper;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Repositories;

namespace FBSApp.Services
{
    public class StaffService : IStaffService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StaffService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<StaffDTO> GetAll()
        {
            var staff = _unitOfWork.StaffRepository.GetAll(s => s.Country);
            return _mapper.Map<IEnumerable<StaffDTO>>(staff);
        }
    }
}
