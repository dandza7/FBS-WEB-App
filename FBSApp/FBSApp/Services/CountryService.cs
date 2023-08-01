using AutoMapper;
using FBSApp.Models.DTOs.Country;
using FBSApp.Repositories;

namespace FBSApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<CountryPreviewDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<CountryPreviewDTO>>(_unitOfWork.CountryRepository.GetAll().OrderBy(c => c.Name));
        }
    }
}
