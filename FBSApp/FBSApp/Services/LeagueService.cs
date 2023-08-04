using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.League;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace FBSApp.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LeagueService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewLeagueDTO newLeague)
        {
            if (_unitOfWork.LeagueRepository.GetAll().Where(l => l.Name == newLeague.Name).Any())
            {
                throw new DuplicateItemException($"League with name {newLeague.Name} already exists!");
            }
            var league = _unitOfWork.LeagueRepository.Create(_mapper.Map<League>(newLeague));
            _unitOfWork.SaveChanges();
            return league.Id;
        }

        public IEnumerable<LeagueDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<LeagueDTO>>(_unitOfWork.LeagueRepository.GetAll());
        }
    }
}
