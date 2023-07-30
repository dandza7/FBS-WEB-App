using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.User;
using FBSApp.Repositories;
using FBSApp.SupportClasses.PasswordHasher;

namespace FBSApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public JWTokenWrapper Login(LoginDTO login)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == login.Email).FirstOrDefault();
            if (user == null)
            {
                return new JWTokenWrapper { Token = "los email", ExpirationDate = DateTime.Now };
            }
            if (!PasswordHasher.VerifyPassword(login.Password, user.Password, user.Salt))
            {
                return new JWTokenWrapper { Token = "los pw", ExpirationDate = DateTime.Now };
            }
            return new JWTokenWrapper { Token = "dobar", ExpirationDate = DateTime.Now };
        }

        public long Register(NewUserDTO newUser)
        {
            if (_unitOfWork.UserRepository.GetAll().Where(u => u.Email == newUser.Email).Any())
            {
                return -1;
            }
            byte[] salt;
            var user = new User
            {
                Email = newUser.Email,
                Password = PasswordHasher.HashPassword(newUser.Password, out salt),
                Role = "USER",
                Salt = salt
            };
            var createdUser = _unitOfWork.UserRepository.Create(user);
            _unitOfWork.SaveChanges();
            return createdUser.Id;
        }
    }
}
