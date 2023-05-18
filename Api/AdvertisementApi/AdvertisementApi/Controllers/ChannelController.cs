using AdIntegration.Data.Dto.ChannelDto.Add;
using AdIntegration.Data.Dto.ChannelDto.Update;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ChannelController : ControllerBase
{
    private readonly IChannelRepository _channelRepository;
    private readonly ILogger _logger;

    public ChannelController(IChannelRepository channelRepository, ILogger logger)
    {
        _channelRepository = channelRepository;
        _logger = logger;
    }

    [HttpPost("telegram/add")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult AddTelegramChannel(AddTelegramChannelDto dto)
    {
        var createdChannel = new TelegramChannel
        {

        };
        return Ok();
    }

    [HttpPost("viber/add")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult AddViberChannel(AddViberChannelDto dto)
    {
        var createdChannel = new ViberChannel
        {

        };

        return Ok();
    }

    [HttpPost("whatsapp/add")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult AddWhatsAppChannel(AddWhatsAppChannelDto dto)
    {
        var createdChannel = new WhatsAppChannel
        {

        };

        return Ok();
    }

    [HttpPut("viber/edit/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult EditViberChannel(int id, UpdateViberChannelDto dto)
    {
        var viberChannel = _channelRepository.GetChannelById(id);

        if (viberChannel == null)
        {
            return BadRequest();
        }

        var editedChannel = new ViberChannel
        {

        };

        return Ok();
    }

    [HttpPut("telegram/edit/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult EditTelegramChannel(int id, UpdateTelegramChannelDto dto)
    {
        var editedChannel = new TelegramChannel
        {

        };

        return Ok();
    }

    [HttpPut("whatsapp/edit/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult EditWhatsAppChannel(int id, UpdateWhatsAppChannel dto)
    {
        var whatsAppChannel = _channelRepository.GetChannelById(id);
        var editedChannel = new WhatsAppChannel
        {
            Name = dto.Name,
            Description = dto.Description,
            Photo = dto.Photo,
            IsPrivate = dto.IsPrivate,
            Email = dto.Email,
            UrlAddress = dto.UrlAddress,
            Category = dto.Category,
            Subcategory = dto.Subcategory
        };

        return Created("success",
            _channelRepository.UpdateChannelById(id, editedChannel));
    }

    [HttpDelete("whatsapp/delete/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteWhatsAppChannel(int id)
    {
        _channelRepository.DeleteChannelById(id);
        return NoContent();
    }

    [HttpDelete("viber/delete/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteViberChannel(int id)
    {
        _channelRepository.DeleteChannelById(id);
        return NoContent();
    }

    [HttpDelete("telegram/delete/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteTelegramChannel(int id)
    {
        _channelRepository.DeleteChannelById(id);
        return NoContent();
    }

    [HttpGet("telegram/channels")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetTelegramChannels()
    {
        return Ok();
    }

    [HttpGet("whatsapp/channels")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetWhatsAppChannels()
    {
        return Ok();
    }

    [HttpGet("viber/channels")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetViberChannels()
    {
        return Ok();
    }

    [HttpGet("channels")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetAllChannels()
    {
        var channels = _channelRepository.GetChannels();
        return Ok(channels);
    }
}
