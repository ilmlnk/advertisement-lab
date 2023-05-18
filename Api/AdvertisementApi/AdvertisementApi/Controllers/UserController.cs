using AdIntegration.Business.Services;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[Authorize(Roles = "User")]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController() { }

    public UserController(UserService userService)
    {
        _userService = userService;
    }


    [HttpGet("users")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetAllUsers()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("users/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetUserById(int id)
    {
        var user = _userService.GetUserById(id);

        if (user == null)
        {
            return BadRequest("User is not found!");
        }

        return Ok(user);
    }

    public IActionResult GetOnlineUsers()
    {
        return Ok();
    }

    private IEnumerable<SystemUser> GetOnlineUsersFromDataSource()
    {
        return null;
    }

}
