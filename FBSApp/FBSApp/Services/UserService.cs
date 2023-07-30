using AutoMapper;
using FBSApp.Models;
using FBSApp.Models.DTOs.User;
using FBSApp.Repositories;
using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using FBSApp.SupportClasses.JWT;
using FBSApp.SupportClasses.PasswordHasher;

namespace FBSApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJWTGenerator _JWTGenerator;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IJWTGenerator JWTGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _JWTGenerator = JWTGenerator;
        }
        public JWTokenWrapper Login(LoginDTO login)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == login.Email).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"There is not user in database with email: {login.Email}.");
            }
            if (!PasswordHasher.VerifyPassword(login.Password, user.Password, user.Salt))
            {
                throw new BadCredentialsException();
            }
            return _JWTGenerator.GenerateToken(user);
        }

        public long Register(NewUserDTO newUser)
        {
            if (_unitOfWork.UserRepository.GetAll().Where(u => u.Email == newUser.Email).Any())
            {
                throw new DuplicateItemException($"There is already user in database with email: {newUser.Email}.");
            }
            byte[] salt;
            var user = _mapper.Map<User>(newUser);
            user.Password = PasswordHasher.HashPassword(newUser.Password, out salt);
            user.Salt = salt;
            user.Role = "USER";
            var createdUser = _unitOfWork.UserRepository.Create(user);
            _unitOfWork.SaveChanges();
            return createdUser.Id;
        }
    }
}
