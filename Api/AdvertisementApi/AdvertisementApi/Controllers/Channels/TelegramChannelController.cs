using AdIntegration.Business.Services;
using AdIntegration.Business.Services.Channels;
using AdIntegration.Data.Dto.ChannelDto.Add;
using AdIntegration.Data.Dto.ChannelDto.Update;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Channels;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class TelegramChannelController : ControllerBase
{
    private readonly TelegramChannelService _channelService;
    public TelegramChannelController(TelegramChannelService channelService)
    {
        _channelService = channelService;
    }

    [HttpPost("add/channel/telegram")]
    public async Task<IActionResult> AddTelegramChannel(AddTelegramChannelDto dto)
    {
        return Ok();
    }

    [HttpDelete("delete/channel/telegram/{id}")]
    public async Task<IActionResult> DeleteTelegramChannel(int id)
    {
        return Ok();
    }

    [HttpPut("update/channel/telegram/{id}")]
    public async Task<IActionResult> UpdateTelegramChannel(UpdateTelegramChannelDto dto)
    {
        return Ok();
    }

    [HttpGet("channel/telegram/{id}")]
    public async Task<IActionResult> GetTelegramChannelById(int id)
    {
        return Ok();
    }


}
