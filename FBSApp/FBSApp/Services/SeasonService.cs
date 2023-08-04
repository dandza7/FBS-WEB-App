using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.Season;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

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
            if (!_unitOfWork.LeagueRepository.GetAll().Where(l => l.Id == leagueId).Any())
            {
                throw new NotFoundException($"League with ID {leagueId} does not exist.");
            }
            return _mapper.Map<IEnumerable<SeasonDTO>>(_unitOfWork.SeasonRepository.GetAll(s => s.League).Where(s => s.LeagueId == leagueId));
        }

        public IEnumerable<TeamListPreviewDTO> GetTeamsInSeason(long seasonId)
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Include(s => s.Teams).ThenInclude(t => t.Country).Where(s => s.Id == seasonId).FirstOrDefault();
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            return _mapper.Map<List<TeamListPreviewDTO>>(season.Teams.OrderBy(t => t.Name));
        }
    }
}
