using AdIntegration.Business.Interfaces.Entities_Service;
using AdIntegration.Business.Services;
using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AdIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserAccountController : ControllerBase
{
    private readonly UserAccountService _userAccountService;

    public UserAccountController(UserAccountService userAccountService)
    {
        _userAccountService = userAccountService;
    }

    /*[AllowAnonymous]
    [HttpPost("register")]
    public IActionResult Register(RegisterUserDto dto)
    {
        var existingUser = _userRepository.GetUserByUsername(dto.UserName);

        if (existingUser != null)
        {
            return StatusCode(409, "User with this username is already registered!");
        }
        else
        {
            var user = new SystemUser
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            return Created("success", _userRepository.AddUser(user));
        }
    }


    [Authorize]
    [HttpPut("update/{id}")]
    public IActionResult UpdateUser(int userId, UpdateUserDto dto)
    {
        var user = _context.Users.Find(userId);

        if (user == null)
        {
            return NotFound("User was not found.");
        }


        _context.SaveChanges();
        return Ok(dto);
    }*/
}
