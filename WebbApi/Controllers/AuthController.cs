using Infrastructures.Contexts;
using Infrastructures.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebbApi.Filters;

namespace WebbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(DataContext context, IConfiguration configuration) : ControllerBase
{
    private readonly IConfiguration _configuration = configuration;
    private readonly DataContext _context = context;

    [UseApiKey]
    [HttpPost]
    [Route("token")]
    public IActionResult GetToken(SignInModel model)
    {
        if (ModelState.IsValid)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new(ClaimTypes.Email, model.Email!),
                    new(ClaimTypes.Name, model.Email!)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return Ok(tokenString);
        }

        return Unauthorized();
    }
}
