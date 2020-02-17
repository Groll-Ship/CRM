using data;
using data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using TestWeb.Identity.interfaces;
using TestWeb.Options;

namespace TestWeb.Identity
{
    public class JwtTokenGenerator : ITokenGenerator
    {
        private readonly IConfiguration _config;

        private List<UserLogin> _users = new List<UserLogin>
        {
            new UserLogin { LoginName="adminName", Password="12345", Role = "admin" },
            new UserLogin { LoginName="hrName", Password="55555", Role = "hr" }
        };
        
        public JwtTokenGenerator(IConfiguration config) =>_config = config;

        public string GenerateToken(UserLogin user)
        {
            var section = _config.GetSection("AuthOptions");
            var jwtOptions = section.Get<AuthOptions>();

            var indentity = GetIndentity(user);
            var now = DateTime.UtcNow;
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtOptions.Secret));
            var credantials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(
                issuer: jwtOptions.Issuer,
                audience: jwtOptions.Audience,
                notBefore: now,
                claims: indentity.Claims,
                expires: now.AddMinutes(jwtOptions.Lifetime),
                signingCredentials: credantials
                );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        private ClaimsIdentity GetIndentity(UserLogin user)
        {
            var claim = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.LoginName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role),
                new Claim("Role", user.Role),
            };

            ClaimsIdentity claimIndentity = new ClaimsIdentity(
                claim,
                "token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType
                );
            return claimIndentity;
        }
    }
}
