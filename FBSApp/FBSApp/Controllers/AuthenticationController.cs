using FBSApp.Models.DTOs.User;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// [Anonymous] Authenticates user
        /// </summary>
        [HttpPost("Login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<JWTokenWrapper> Login([FromBody] LoginDTO login)
        {
            return Ok(_userService.Login(login));
        }

        /// <summary>
        /// [Anonymous] Registers user
        /// </summary>
        [HttpPost("Register", Name = "Register")]
        [AllowAnonymous]
        public ActionResult<long> Register([FromBody] NewUserDTO newUser)
        {
            return Ok(_userService.Register(newUser));
        }
    }
}
