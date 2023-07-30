using FBSApp.Models.DTOs.User;

namespace FBSApp.Services
{
    public interface IUserService
    {
        long Register(NewUserDTO newUser);
        JWTokenWrapper Login(LoginDTO login);
    }
}
