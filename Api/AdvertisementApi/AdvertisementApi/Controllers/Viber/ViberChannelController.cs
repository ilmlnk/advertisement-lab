using AdIntegration.Api.Controllers.Telegram;
using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Dto.Viber.Channel;
using AdIntegration.Data.Entities.Viber;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Viber;

[ApiController]
[Route("api/[controller]")]
public class ViberChannelController : ControllerBase
{
    private readonly IViberChannelService _channelService;
    private readonly ILog log = LogManager.GetLogger(typeof(TelegramAdvertisementController));

    public ViberChannelController(IViberChannelService channelService)
    {
        _channelService = channelService;
    }

    [HttpPost("viber/channel/add")]
    public async Task<IActionResult> AddViberChannel([FromBody] AddViberChannelDto dto)
    {
        try
        {
            var preparedChannel = new ViberChannel
            {
                Name = dto.Name,
                Description = dto.Description,
                PhotoUrl = dto.PhotoUrl,
                BackgroundPhotoUrl = dto.BackgroundPhotoUrl,
                IsPrivate = dto.IsPrivate,
                ChannelUrl = dto.ChannelUrl,
                Category = dto.Category,
                Subcategory = dto.Subcategory,
                Location = dto.Location,
                Email = dto.Email,
                WebsiteUrl = dto.WebsiteUrl,
                IsPublished = dto.IsPublished
            };

            await _channelService.AddViberChannel(preparedChannel);

            return Ok(preparedChannel);
        } catch (Exception ex)
        {
            log.Error(ex);
            throw;
        }
    }

    [HttpGet("viber/channel/find/{id}")]
    public async Task<IActionResult> GetViberChannelById(int id)
    {
        try
        {
            var foundChannel = await _channelService.GetViberChannelById(id);

            if (foundChannel == null)
            {
                log.Warn("Channel was not found");
                return NotFound();
            }

            return Ok(foundChannel);
        } catch (Exception ex)
        {
            log.Error(ex.Message);
            return BadRequest();
        }
    }

    [HttpDelete("viber/channel/delete/{id}")]
    public async Task<IActionResult> DeleteViberChannelById(int id)
    {
        try
        {
            var foundChannel = await _channelService.GetViberChannelById(id);

            if (foundChannel == null)
            {
                return BadRequest();
            }

            var deletedChannel = await _channelService.DeleteViberChannelById(id);
            return Ok(deletedChannel);
        } catch(Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("viber/channel/update/{id}")]
    public async Task<IActionResult> UpdateViberChannelById(int id, [FromForm] UpdateViberChannelDto dto)
    {
        try
        {
            var foundChannel = await _channelService.GetViberChannelById(id);

            if (foundChannel == null)
            {
                return BadRequest();
            }

            var preparedChannel = new ViberChannel
            {
                Name = dto.Name,
                Description = dto.Description,
                PhotoUrl = dto.PhotoUrl,
                BackgroundPhotoUrl = dto.BackgroundPhotoUrl,
                IsPrivate = dto.IsPrivate,
                ChannelUrl = dto.ChannelUrl,
                Category = dto.Category,
                Subcategory = dto.Subcategory,
                Location = dto.Location,
                Email = dto.Email,
                WebsiteUrl = dto.WebsiteUrl
            };

            var updatedChannel = await _channelService.UpdateViberChannelById(id, preparedChannel);
            return Ok(updatedChannel);
        } catch (Exception e)
        {
            log.Error(e);
            return BadRequest(e.Message);
        }
    }
}
