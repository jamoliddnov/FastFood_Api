using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Interfaces.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FastFood_Web.Service.Common.Security
{
    public class AuthManager : IAuthManager
    {
        private readonly IConfiguration _configuration;
        public AuthManager(IConfiguration configuration)
        {
            _configuration = configuration.GetSection("Jwt");
        }

        public string GenerateToken(User customer)
        {
            var claims = new[] {
                new Claim("Id", customer.Id.ToString()),
                new Claim(ClaimTypes.Email, customer.Email),
                new Claim(ClaimTypes.Role, customer.UserRole.ToString())
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var tokenDeskriptor = new JwtSecurityToken(_configuration["Issuer"], _configuration["Audience"], claims,
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["Lifetime"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(tokenDeskriptor);
        }
    }
}






