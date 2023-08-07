﻿using AutoMapper;
using FBSApp.Models.DTOs;
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

        public PaginationWrapper<StaffDTO> GetAll(int page, int pageSize)
        {
            var staff = _unitOfWork.StaffRepository.GetAll(s => s.Country);
            var totalCount = staff.Count();
            return new PaginationWrapper<StaffDTO> { Entities = _mapper.Map<IEnumerable<StaffDTO>>(staff.Skip((page - 1) * pageSize).Take(pageSize)), TotalCount = totalCount };
        }

        public IEnumerable<TeamEmploymentDTO> GetEmployments(long staffId)
        {
            var employments = _unitOfWork.TeamEmploymentRepository.GetAll(te => te.Team).Where(te => te.StaffId == staffId);
            return employments.Select(e => new TeamEmploymentDTO
            {
                TeamName = e.Team.Name,
                TeamLogo = e.Team.Logo,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
            });
        }
    }
}