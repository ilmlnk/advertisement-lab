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
        try
        {
            var preparedUser = new WhatsAppUser
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.UserName,
                PhotoUrl = dto.PhotoUrl,
                PhoneNumber = dto.PhoneNumber
            };

            var addedUser = await _userService.AddWhatsAppUser(preparedUser);
            return Ok(addedUser);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("whatsapp/user/update/{id}")]
    public async Task<IActionResult> UpdateWhatsAppUser([FromForm] UpdateWhatsAppUserDto dto)
    {
        throw new NotImplementedException();
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
