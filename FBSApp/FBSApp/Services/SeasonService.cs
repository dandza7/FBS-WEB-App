using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Match;
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

        public PaginationWrapper<MatchListPreviewDTO> GetMatchesInSeason(long seasonId, int page, int pageSize)
        {
            if (!_unitOfWork.SeasonRepository.GetAll().Where(s => s.Id == seasonId).Any())
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var matchesRaw = _unitOfWork.MatchRepository.GetAll(m => m.Season)
                                                    .Include(m => m.MatchActors).ThenInclude(ma => ma.Team).ThenInclude(t => t.Country)
                                                    .Where(m => m.SeasonId == seasonId).OrderByDescending(m => m.Date);
            var totalCount = matchesRaw.Count();
            var matches = matchesRaw.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationWrapper<MatchListPreviewDTO>
            {
                Entities = matches.Select(m => new MatchListPreviewDTO
                {
                    Id = m.Id,
                    Date = m.Date,
                    HomeTeamGoals = 0, // TO-DO
                    AwayTeamGoals = 0, // TO-DO
                    HomeTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team),
                    AwayTeam = m.MatchActors.First().IsTeamHost ? _mapper.Map<TeamListPreviewDTO>(m.MatchActors.Last().Team) : _mapper.Map<TeamListPreviewDTO>(m.MatchActors.First().Team),
                }),
                TotalCount = totalCount
            };
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

        public IEnumerable<TeamTableViewDTO> GetDefaultTable(long seasonId)
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Include(s => s.Teams).ThenInclude(t => t.Country)
                                                              .Where(s => s.Id == seasonId).FirstOrDefault();
            if (season == null)
            {
                throw new NotFoundException($"Season with ID {seasonId} does not exist.");
            }
            var teams = season.Teams;
            return teams.Select(t => new TeamTableViewDTO
            {
                Name = t.Name,
                Logo = t.Logo,
                Flag = t.Country.Flag,
                Wins = 0,
                Draws = 0,
                Losses = 0,
                MatchesPlayed = 0,
                GoalsScored = 0,
                GoalsConceded = 0,
                Points = 0
            }).OrderBy(t => t.Points);
        }
    }
}
