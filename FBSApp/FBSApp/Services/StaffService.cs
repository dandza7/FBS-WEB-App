using AutoMapper;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Staff;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

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

        public PaginationWrapper<StaffDTO> GetAll(int page, int pageSize)
        {
            var staff = _unitOfWork.StaffRepository.GetAll(s => s.Country).OrderBy(s => s.BossId);
            var totalCount = staff.Count();
            return new PaginationWrapper<StaffDTO> { Entities = _mapper.Map<IEnumerable<StaffDTO>>(staff.Skip((page - 1) * pageSize).Take(pageSize)), TotalCount = totalCount };
        }

        public IEnumerable<TeamEmploymentDTO> GetEmployments(long staffId)
        {
            var employments = _unitOfWork.TeamEmploymentRepository.GetAll(te => te.Team).Where(te => te.StaffId == staffId);
            return employments.Select(e => new TeamEmploymentDTO
            {
                TeamId = e.TeamId,
                TeamName = e.Team.Name,
                TeamLogo = e.Team.Logo,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
            });
        }

        public StaffDTO GetOne(long id)
        {
            var staff = _unitOfWork.StaffRepository.GetAll(s => s.Country).FirstOrDefault(s => s.Id == id);
            if (staff == null)
            {
                throw new NotFoundException($"Staff with ID {id} doest not exist!");
            }
            return _mapper.Map<StaffDTO>(staff);
        }

        public IEnumerable<AwardDTO> GetStaffAwards(long staffId)
        {
            if (!_unitOfWork.StaffRepository.GetAll().Any(s => s.Id == staffId))
            {
                throw new NotFoundException($"Staff with ID {staffId} doest not exist!");
            }
            var awards = _unitOfWork.AwardRepository.GetAll().Where(a => a.StaffId == staffId).Include(a => a.Season).ThenInclude(s => s.League);
            return _mapper.Map<IEnumerable<AwardDTO>>(awards);
        }
    }
}
