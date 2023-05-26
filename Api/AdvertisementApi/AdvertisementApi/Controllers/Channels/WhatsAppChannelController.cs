using AdIntegration.Business.Services.Channels;
using AdIntegration.Data.Dto.ChannelDto.Add;
using AdIntegration.Data.Entities.WhatsApp;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Channels;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class WhatsAppChannelController : ControllerBase
{
    private readonly WhatsAppChannelService _channelService;
    public WhatsAppChannelController(WhatsAppChannelService channelService)
    {
        _channelService = channelService;
    }

    [HttpPost("add/channel/whatsapp")]
    public async Task<IActionResult> AddWhatsAppChannel(AddWhatsAppChannelDto dto)
    {
        var onCreateChannel = new WhatsAppChannel
        {

        };

        return Ok();
    }
}
