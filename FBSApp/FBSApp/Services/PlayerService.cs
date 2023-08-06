﻿using AutoMapper;
using FBSApp.Models.DTOs;
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
    }
}
