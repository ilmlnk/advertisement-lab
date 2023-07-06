using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Dto.WhatsApp.Channel;
using AdIntegration.Data.Entities.WhatsApp;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.WhatsApp;

[ApiController]
[Route("api/[controller]")]
public class WhatsAppChannelController : ControllerBase
{
    private readonly IWhatsAppChannelService _channelService;
    private readonly ILog log = LogManager.GetLogger(typeof(WhatsAppChannelController));

    public WhatsAppChannelController(IWhatsAppChannelService channelService)
    {
        _channelService = channelService;
    }

    [HttpPost("whatsapp/channel/add")]
    public async Task<IActionResult> AddWhatsAppChannel([FromBody] AddWhatsAppChannelDto dto)
    {
        var preparedChannel = new WhatsAppChannel
        {
            Name = dto.Name,
            Description = dto.Description,
            PhotoUrl = dto.PhotoUrl,
        };

        var addedChannel =  await _channelService.AddWhatsAppChannel(preparedChannel);
        return Ok(addedChannel);
    }

    [HttpGet("whatsapp/channel/{id}")]
    public async Task<IActionResult> GetWhatsAppChannelById(int id)
    {
        var foundChannel = await _channelService.GetWhatsAppChannelById(id);
        return Ok(foundChannel);
    }

    [HttpGet("whatsapp/channels")]
    public async Task<IActionResult> GetWhatsAppChannels()
    {
        try
        {
            var foundChannels = await _channelService.GetWhatsAppChannels();
            return Ok(foundChannels);
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("whatsapp/channel/delete/{id}")]
    public async Task<IActionResult> DeleteWhatsAppChannelById(int id)
    {
        var foundChannel = await _channelService.GetWhatsAppChannelById(id);
        
        if (foundChannel == null)
        {
            return NotFound();
        }

        var deletedChannel = await _channelService.DeleteWhatsAppChannelById(id);
        return Ok(deletedChannel);
    }
}
