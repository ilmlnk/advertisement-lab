using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Dto.Viber.Channel;
using AdIntegration.Data.Dto.Viber.User;
using AdIntegration.Data.Entities.Viber;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Viber;

[ApiController]
[Route("api/[controller]")]
public class ViberUserController : ControllerBase
{
    private readonly IViberUserService _userService;
    private readonly ILog log = LogManager.GetLogger(typeof(ViberUserController));

    public ViberUserController(IViberUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("viber/user/find/{id}")]
    public async Task<IActionResult> GetViberUserById(int id)
    {
        try
        {
            var foundUser = await _userService.GetViberUserById(id);

            if (foundUser == null)
            {
                return BadRequest();
            }

            return Ok(foundUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("viber/users")]
    public async Task<IActionResult> GetViberUsers()
    {
        try
        {
            var foundUsers = await _userService.GetViberUsers();
            return Ok(foundUsers);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

    [HttpPost("viber/user/add")]
    public async Task<IActionResult> AddViberUser([FromForm] AddViberUserDto dto)
    {
        try
        {
            var preparedUser = new ViberUser
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.UserName,
                PhotoUrl = dto.PhotoUrl,
                PhoneNumber = dto.PhoneNumber
            };

            await _userService.AddViberUser(preparedUser);
            return Ok(preparedUser);
        }
        catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

    [HttpDelete("viber/user/delete/{id}")]
    public async Task<IActionResult> DeleteViberUserById(int id)
    {
        try
        {
            var foundUser = await _userService.GetViberUserById(id);

            if (foundUser == null)
            {
                log.Warn("User was not found.");
                return BadRequest();
            }

            await _userService.DeleteViberUserById(id);
            return Ok(foundUser);
        }
        catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

    [HttpPut("viber/user/update/{id}")]
    public async Task<IActionResult> UpdateViberUserById(int id, [FromBody] UpdateViberUserDto dto)
    {
        try
        {
            var foundUser = await _userService.GetViberUserById(id);

            if (foundUser == null)
            {
                log.Warn("User was not found.");
                return NotFound();
            }

            foundUser.FirstName = dto.FirstName;
            foundUser.LastName = dto.LastName;
            foundUser.UserName = dto.UserName;
            foundUser.PhotoUrl = dto.PhotoUrl;
            foundUser.PhoneNumber = dto.PhoneNumber;

            var updatedUser = await _userService.UpdateViberUserById(id, foundUser);
            return Ok(updatedUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

}
