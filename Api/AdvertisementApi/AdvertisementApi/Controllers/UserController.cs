using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace AdIntegration.Api.Controllers;

[Authorize(Roles = "User")]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ILogger<UserController> _logger;

    public UserController(UserService userService, UserManager<IdentityUser> userManager, ILogger<UserController> logger)
    {
        _userService = userService;
        _userManager = userManager;
        _logger = logger;
    }


    [HttpPost("user/create")]
    public async Task<IActionResult> CreateUser([FromBody] RegisterUserDto dto)
    {
        var user = new SystemUser
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email
        };

        try
        {
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(dto.Role))
                {
                    await _userManager.AddToRoleAsync(user, dto.Role);
                }
                return Ok("User was created successfully!");
            }
            return BadRequest(result.Errors);
        } catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return StatusCode(500, "Attempt to create new user was failed.");
        }
    }

    [HttpPut("user/update/{id}")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto)
    {
        return Ok();
    }



}
