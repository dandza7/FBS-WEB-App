﻿using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.League;
using FBSApp.Models.DTOs.Season;
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
            var country = _unitOfWork.CountryRepository.GetAll().Where(c => c.Id == newLeague.CountryId).FirstOrDefault();
            if (country == null)
            {
                throw new NotFoundException($"Country with ID {newLeague.CountryId} does not exist!");
            }
            var league = _unitOfWork.LeagueRepository.Create(new League
            {
                Name = newLeague.Name,
                Country = country
            });
            _unitOfWork.SaveChanges();
            return league.Id;
        }

        public IEnumerable<LeagueDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<LeagueDTO>>(_unitOfWork.LeagueRepository.GetAll(l => l.Country));
        }

        public LeagueDTO GetById(long id)
        {
            var league = _unitOfWork.LeagueRepository.GetAll(l => l.Country).FirstOrDefault(l => l.Id == id);
            if (league == null)
            {
                throw new NotFoundException($"League with ID {id} does not exist!");
            }
            return new LeagueDTO
            {
                Id = league.Id,
                Name = league.Name,
                Flag = league.Country.Flag,
                Seasons = _mapper.Map<IEnumerable<SeasonDTO>>(_unitOfWork.SeasonRepository.GetAll().Where(s => s.LeagueId == id).ToList()),
            };
        }
    }
}
