using AutoMapper;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;

namespace FBSApp.Services
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<TeamListPreviewDTO> GetListed(TeamFilterQuery query)
        {
            var teams = _unitOfWork.TeamRepository.GetAll(t => t.Country).Where(t => t.Name.Contains(query.Name));
            if (query.CountryId != 0)
            {
                teams = teams.Where(t => t.CountryId == query.CountryId);
            }
            var count = teams.Count();
            List<TeamListPreviewDTO> teamsList = new List<TeamListPreviewDTO>();
            if (query.IsOrderAscending)
            {
                teamsList = _mapper.Map<List<TeamListPreviewDTO>>(teams.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                teamsList = _mapper.Map<List<TeamListPreviewDTO>>(teams.OrderByDescending(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            return new PaginationWrapper<TeamListPreviewDTO>
            {
                TotalCount = count,
                Entities = teamsList
            };
        }
    }
}
