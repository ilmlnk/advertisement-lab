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

namespace AdIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemUserAccountController : ControllerBase
{
    private readonly ISystemUserService _systemUserService;
    private readonly ILog log = LogManager.GetLogger(typeof(SystemUserAccountController));
    public SystemUserAccountController(ISystemUserService systemUserService)
    {
        _systemUserService = systemUserService;
    }

    private void CreatePasswordHash(string password)
    {
        using (var hmac = new HMACSHA512())
        {
            
        }
    }

    [HttpPost("user/register")]
    public async Task<IActionResult> Register([FromForm] RegisterSystemUserDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var systemUser = new SystemUser
        {
            UserName = dto.UserName,
            Password = dto.Password
        };


    }

}


/*private readonly ISystemUserService _systemUserService;
        private readonly ILogger<SystemUserAccountController> _logger;
        private readonly JwtService _jwtService;

        public SystemUserAccountController(ISystemUserService systemUserService, ILogger<SystemUserAccountController> logger, JwtService jwtService)
        {
            _systemUserService = systemUserService;
            _logger = logger;
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public Task<IActionResult> Register(RegisterSystemUserDto dto)
        {
            try
            {
                var user = new SystemUser
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    Username = dto.UserName,
                    Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
                };

                _systemUserService.RegisterSystemUser(user);
            } catch (Exception ex)
            {

            }

            var userId = user.UserId;
            return Task.FromResult<IActionResult>(Redirect($"http://localhost:3000/admin/{userId}"));
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public Task<IActionResult> Login(LoginSystemUserDto dto)
        {
            var userFromDto = _systemUserService.GetUserByUsername(dto.UserName);
            var userId = userFromDto?.UserId;

            if (userFromDto == null) {
                return Task.FromResult<IActionResult>(NotFound());
            }

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, userFromDto.PasswordHash))
            {
                return Task.FromResult<IActionResult>(Unauthorized());
            }

            var jwt = _jwtService.Generate(userFromDto.UserId);

            return Task.FromResult<IActionResult>(Redirect($"http://localhost:3000/admin/{userId}"));
            
        }*/