using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Season;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace FBSApp.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeasonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewSeasonDTO newSeason)
        {
            if (_unitOfWork.SeasonRepository.GetAll().Where(l => l.Year == newSeason.Year && l.LeagueId == newSeason.LeagueId).Any())
            {
                throw new DuplicateItemException($"Selected league already has season in year(s) {newSeason.Year}");
            }
            var season = _unitOfWork.SeasonRepository.Create(_mapper.Map<Season>(newSeason));
            _unitOfWork.SaveChanges();
            return season.Id;
        }

        public IEnumerable<SeasonDTO> GetAll(long leagueId)
        {
            return _mapper.Map<IEnumerable<SeasonDTO>>(_unitOfWork.SeasonRepository.GetAll(s => s.League).Where(s => s.LeagueId == leagueId));
        }
    }
}
