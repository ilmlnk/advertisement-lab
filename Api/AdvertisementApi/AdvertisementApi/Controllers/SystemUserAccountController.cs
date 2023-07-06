using AdIntegration.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AdIntegration.Repository.Interfaces;
using AdIntegration.Api.Helpers;
using AdIntegration.Data;
using AutoMapper;
using AdIntegration.Data.Entities.Abstractions;
using AdIntegration.Data.Dto.User;
using AdIntegration.Repository.Repositories;
using System.Configuration;
using AdIntegration.Business.Interfaces;
using log4net;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using AdIntegration.Api.AppSetting;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Diagnostics.Eventing.Reader;

namespace AdIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemUserAccountController : ControllerBase
{
    private readonly ApplicationSettings _appSettings;
    private UserManager<SystemUser> _userManager;
    
    private readonly ISystemUserService _systemUserService;
    private readonly ILog log = LogManager.GetLogger(typeof(SystemUserAccountController));
    public SystemUserAccountController(UserManager<SystemUser> userManager, IOptions<ApplicationSettings> appSettings)
    {
        _userManager = userManager;
        _appSettings = appSettings.Value;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginSystemUserDto dto)
    {
        var user = await _userManager.FindByNameAsync(dto.UserName);
        if (user != null)
        {
            try
            {
                IdentityOptions _options = new IdentityOptions();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString()),
                        new Claim("UserName", user.UserName),
                        new Claim("FullName", user.FirstName + " " + user.LastName),
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWTSecret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                user.IsOnline = true;
                return Ok(new { token, user });
            } catch
            {
                throw;
            }
        } else
        {
            return BadRequest(new { message = "Username or password is incorrect." });
        }
    }

    /*public async Task<object> Register(RegisterSystemUserDto dto)
    {
        var applicationUser = new SystemUser
        {

        };

        try
        {
            var result = await _userManager.CreateAsync(applicationUser, password);
            return Ok(result);
        } catch
        {
            throw;
        }
    }*/

}
