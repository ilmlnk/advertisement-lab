using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.UserDto.Admin;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/[controller]")]
public class AdminController : ControllerBase
{
    private readonly AdminService _adminService;
    private readonly UserManager<SystemUser> _userManager;
    private readonly ILogger _logger;

    public AdminController(AdminService adminService, UserManager<SystemUser> userManager, ILogger logger)
    {
        _adminService = adminService;
        _userManager = userManager;
        _logger = logger;
    }

    [HttpPost("join")]
    public async Task<IActionResult> CreateAdmin([FromBody] JoinOurTeamDto dto)
    {
        var user = new SystemUser
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            UserName = dto.UserName
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
                return Ok("Admin was created successfully!");
            }

            return BadRequest(result.Errors);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return StatusCode(500, "Attempt to create admin was failed.");
        }
    }
}
