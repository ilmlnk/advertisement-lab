using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Data.Dto.Telegram.Channel;
using AdIntegration.Data.Entities.Telegram;
using log4net;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Algorithm.Distance;

namespace AdIntegration.Api.Controllers.Telegram;

[ApiController]
[Route("api/[controller]")]
public class TelegramChannelController : ControllerBase
{
    private readonly ITelegramChannelService _channelService;
    private readonly ILog log = LogManager.GetLogger(typeof(TelegramChannelController));
    public TelegramChannelController(ITelegramChannelService channelService)
    {
        _channelService = channelService;
    }

    [HttpGet("telegram/channels/{id}")]
    public async Task<IActionResult> GetTelegramChannelById(int id)
    {
        try
        {
            var foundChannel = await _channelService.GetTelegramChannelById(id);
            if (foundChannel == null)
            {
                log.Warn("Channel was not found.");
                return NotFound();
            }
            return Ok(foundChannel);
        } catch(Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("telegram/channels")]
    public async Task<IActionResult> GetTelegramChannels()
    {
        var foundChannels = await _channelService.GetTelegramChannels();
        return Ok(foundChannels);
    }

    [HttpPost("telegram/channel/add")]
    public async Task<IActionResult> AddTelegramChannel([FromBody] AddTelegramChannelDto dto)
    {
        try
        {
            var preparedChannel = new TelegramChannel
            {
                Name = dto.Name,
                Description = dto.Description,
                PhotoUrl = dto.PhotoUrl,
                IsPrivate = dto.IsPrivate,
                ActiveUsersCount = dto.ActiveUsersCount,
                Posts = dto.Posts,
                InviteLink = dto.InviteLink
            };

            var createdChannel = await _channelService.AddTelegramChannel(preparedChannel);
            return Ok(createdChannel);
        } catch (Exception e)
        {
            log.Error(e);
            return BadRequest(e.Message);
        }
    }
}
