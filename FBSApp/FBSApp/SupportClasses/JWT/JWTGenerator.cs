﻿using FBSApp.Models;
using FBSApp.Models.DTOs.User;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FBSApp.SupportClasses.JWT
{
    public class JWTGenerator : IJWTGenerator
    {
        private readonly IConfiguration _config;
        private readonly JwtSecurityTokenHandler _jwtHandler = new();
        public JWTGenerator(IConfiguration config)
        {
            _config = config;
        }

        public JWTokenWrapper GenerateToken(User user)
        {
            DateTime expirationDate = DateTime.UtcNow.AddDays(1);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = credentials,
                Issuer = _config["Jwt:Issuer"],
                Audience = _config["Jwt:Audience"]
            };

            var token = _jwtHandler.CreateToken(tokenDescriptor);
            return new JWTokenWrapper { Token = _jwtHandler.WriteToken(token), ExpirationDate = expirationDate };
        }
    }
}
