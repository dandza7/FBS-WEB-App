using AutoMapper;
using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Team;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlayerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<PlayerListPreviewDTO> GetListed(PlayerFilterQuery query)
        {
            var players = _unitOfWork.PlayerRepository.GetAll(p => p.Country).Where(p => p.Name.Contains(query.Name));
            if (query.CountryId != 0)
            {
                players = players.Where(p => p.CountryId == query.CountryId);
            }
            if (query.Position != "ALL")
            {
                players = players.Where(p => p.Position == query.Position);
            }
            var count = players.Count();
            List<PlayerListPreviewDTO> playersList = new List<PlayerListPreviewDTO>();
            if (query.IsOrderAscending)
            {
                playersList = _mapper.Map<List<PlayerListPreviewDTO>>(players.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                playersList = _mapper.Map<List<PlayerListPreviewDTO>>(players.OrderByDescending(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            return new PaginationWrapper<PlayerListPreviewDTO>
            {
                TotalCount = count,
                Entities = playersList
            };
        }

        public PlayerListPreviewDTO GetPlayer(long playerId)
        {
            var player = _unitOfWork.PlayerRepository.GetAll(p => p.Country).Where(p => p.Id == playerId).FirstOrDefault();
            if (player == null)
            {
                throw new NotFoundException($"Player with ID {playerId} doest not exist!");
            }
            return _mapper.Map<PlayerListPreviewDTO>(player);
        }

        public IEnumerable<AwardDTO> GetPlayersAwards(long playerId)
        {
            if (!_unitOfWork.PlayerRepository.GetAll().Where(s => s.Id == playerId).Any())
            {
                throw new NotFoundException($"Player with ID {playerId} doest not exist!");
            }
            var awards = _unitOfWork.AwardRepository.GetAll().Where(a => a.PlayerId == playerId).Include(a => a.Season).ThenInclude(s => s.League);
            return _mapper.Map<IEnumerable<AwardDTO>>(awards);
        }

        public IEnumerable<TeamEngagementDTO> GetPlayersEngagements(long playerId)
        {
            if (!_unitOfWork.PlayerRepository.GetAll().Where(p => p.Id == playerId).Any())
            {
                throw new NotFoundException($"Player with ID {playerId} does not exist!");
            }
            var teamEngagements = _unitOfWork.TeamEngagementRepository.GetAll().Where(te => te.PlayerId == playerId)
                                                                               .Include(te => te.Team).ThenInclude(t => t.Country);
            return teamEngagements.Select(te => new TeamEngagementDTO
            {
                Id = te.Id,
                Name = te.Team.Name,
                Logo = te.Team.Logo,
                Flag = te.Team.Country.Flag,
                StartDate = te.StartDate,
                EndDate = te.EndDate,
            });
        }

        public IEnumerable<string> Temp()
        {
            var season = _unitOfWork.SeasonRepository.GetAll().Where(s => s.Id == 1L).FirstOrDefault();
            var players = _unitOfWork.PlayerRepository.GetAll().Where(p => p.Engagements.Where(e => e.StartDate >= DateTime.Parse("Aug 1, 2018") || e.EndDate <= season.EndDate)
                                                                                        .Where(e => e.TeamId == 9).Any())
                                                               .ToList();
            return players.Select(p => $"{p.Id} - {p.Name}");
        }
    }
}
