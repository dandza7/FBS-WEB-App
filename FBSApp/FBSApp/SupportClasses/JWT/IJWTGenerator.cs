using FBSApp.Models;
using FBSApp.Models.DTOs.User;

namespace FBSApp.SupportClasses.JWT
{
    public interface IJWTGenerator
    {
        JWTokenWrapper GenerateToken(User user);
    }
}
