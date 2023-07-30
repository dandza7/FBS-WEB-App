using AutoMapper;
using FBSApp.Models;
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
        /// <response code="200">Returns JWToken and its expiration date</response>
        /// <response code="400">If credentials do not match</response>
        /// <response code="404">If email does not exists in database</response>
        [HttpPost("Login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<JWTokenWrapper> Login([FromBody] LoginDTO login)
        {
            return Ok(_userService.Login(login));
        }

        /// <summary>
        /// [Anonymous] Registers user
        /// </summary>
        /// <response code="200">Returns new users entity ID</response>
        /// <response code="400">If email is already taken</response>
        [HttpPost("Register", Name = "Register")]
        [AllowAnonymous]
        public ActionResult<long> Register([FromBody] NewUserDTO newUser)
        {
            return Ok(_userService.Register(newUser));
        }
    }
}
