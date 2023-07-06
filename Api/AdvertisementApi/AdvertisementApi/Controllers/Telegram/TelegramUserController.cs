using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Data.Dto.Telegram.User;
using AdIntegration.Data.Entities.Telegram;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Telegram;

[ApiController]
[Route("api/[controller]")]
public class TelegramUserController : ControllerBase
{
    private readonly ITelegramUserService _userService;
    private readonly ILog log = LogManager.GetLogger(typeof(TelegramUserController));
    public TelegramUserController(ITelegramUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("telegram/user/add")]
    public async Task<IActionResult> AddTelegramUser([FromBody] AddTelegramUserDto dto)
    {
        try
        {
            var preparedUser = new TelegramUser
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.Username,
                PhotoUrl = dto.PhotoUrl,
                PhoneNumber = dto.PhoneNumber
            };

            var createdUser = await _userService.AddTelegramUser(preparedUser);
            return Ok(createdUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("telegram/user/find/{id}")]
    public async Task<IActionResult> GetTelegramUserById(int id)
    {
        try
        {
            var foundUser = await _userService.GetTelegramUserById(id);

            if (foundUser == null)
            {
                log.Warn("User was not found.");
                return BadRequest();
            }

            return Ok(foundUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("telegram/users")]
    public async Task<IActionResult> GetTelegramUsers()
    {
        try
        {
            var foundUsers = await _userService.GetTelegramUsers();
            return Ok(foundUsers);
        } catch (Exception ex) 
        { 
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("telegram/user/delete/{id}")]
    public async Task<IActionResult> DeleteTelegramUserById(int id)
    {
        try
        {
            var foundUser = await _userService.GetTelegramUserById(id);

            if (foundUser == null)
            {
                return BadRequest();
            }

            var deletedUser = await _userService.DeleteTelegramUserById(id);
            return Ok(deletedUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("telegram/user/update/{id}")]
    public async Task<IActionResult> UpdateTelegramUserById(int id, [FromBody] UpdateTelegramUserDto dto)
    {
        try
        {
            var foundUser = await _userService.GetTelegramUserById(id);

            if (foundUser == null)
            {
                log.Warn("User was not found.");
                return NotFound();
            }

            foundUser.FirstName = dto.FirstName;
            foundUser.LastName = dto.LastName;
            foundUser.UserName = dto.Username;
            foundUser.PhotoUrl = dto.PhotoUrl;
            foundUser.PhoneNumber = dto.PhoneNumber;

            var updatedUser = await _userService.UpdateTelegramUserById(id, foundUser);
            return Ok(updatedUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

}
