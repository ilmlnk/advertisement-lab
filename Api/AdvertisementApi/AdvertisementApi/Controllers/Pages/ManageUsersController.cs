using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Dto.User;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Pages;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class ManageUsersController : ControllerBase
{
    private readonly IManageUsersService _manageUsersService;

    public ManageUsersController(IManageUsersService manageUsersService)
    {
        _manageUsersService = manageUsersService;
    }

    [HttpDelete("system_users/delete/{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("system_users/update/{id}")]
    public async Task<IActionResult> UpdateSystemUserById(int id, [FromBody]UpdateSystemUserDto dto)
    {
        throw new NotImplementedException();
    }

    [HttpGet("system_users")]
    public async Task<IActionResult> GetSystemUsers()
    {
        throw new NotImplementedException();
    }

    [HttpGet("system_users/get/{id}")]
    public async Task<IActionResult> GetSystemUserById(int id)
    {
        throw new Exception();
    }
}
