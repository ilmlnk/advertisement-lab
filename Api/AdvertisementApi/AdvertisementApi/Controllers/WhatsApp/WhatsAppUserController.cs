using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Dto.WhatsApp.Channel;
using AdIntegration.Data.Dto.WhatsApp.User;
using AdIntegration.Data.Entities.WhatsApp;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.WhatsApp;

public class WhatsAppUserController : ControllerBase
{
    private readonly IWhatsAppUserService _userService;
    private readonly ILog log = LogManager.GetLogger(typeof(WhatsAppUserController));

    public WhatsAppUserController(IWhatsAppUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("whatsapp/user/add")]
    public async Task<IActionResult> AddWhatsAppUser([FromForm] AddWhatsAppUserDto dto)
    {
        var preparedUser = new WhatsAppUser
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            UserName = dto.UserName,
            PhotoUrl = dto.PhotoUrl,
            PhoneNumber = dto.PhoneNumber
        };

        try
        {
            var addedUser = await _userService.AddWhatsAppUser(preparedUser);
            return Ok(addedUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("whatsapp/user/update/{id}")]
    public async Task<IActionResult> UpdateWhatsAppUser(int id, [FromForm] UpdateWhatsAppUserDto dto)
    {
        try
        {
            var foundUser = await _userService.GetWhatsAppUserById(id);
            if (foundUser == null)
            {
                log.Warn("User was not found.");
                return NotFound();
            }

            foundUser.FirstName = dto.FirstName;

            return Ok(foundUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return NotFound();
        }
    }

    [HttpGet("whatsapp/user/find/{id}")]
    public async Task<IActionResult> GetWhatsAppUserById(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("whatsapp/users")]
    public async Task<IActionResult> GetWhatsAppUsers()
    {
        var users = await _userService.GetWhatsAppUsers();
        return Ok(users);
    }
}
