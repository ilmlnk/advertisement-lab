using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdIntegration.Business.Models;
using Microsoft.AspNet.SignalR;
using AdIntegration.Data.Dto;
using AdIntegration.Data;
using AdIntegration.Repository.Interfaces;
using AdIntegration.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace AdIntegration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;

        public UserController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            var user = await _authenticateService.AuthenticateUser(loginUserDto);
            var tokenString = _authenticateService.GenerateToken(user);
            return Ok(tokenString);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
        {
            var user = await _authenticateService.CreateUser(registerUserDto);
            var tokenString = _authenticateService.GenerateToken(user);
            return Created("", tokenString);
        }
    }
}
