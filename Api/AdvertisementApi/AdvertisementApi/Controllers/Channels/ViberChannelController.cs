using AdIntegration.Business.Services.Channels;
using AdIntegration.Data.Dto.ChannelDto.Add;
using AdIntegration.Data.Entities.Viber;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Channels;

[Route("api/[controller]")]
[ApiController]
public class ViberChannelController : ControllerBase
{
    private readonly ViberChannelService _viberChannelService;
    private readonly ILogger _logger;

    public ViberChannelController(ViberChannelService viberChannelService, ILogger logger)
    {
        _viberChannelService = viberChannelService;
        _logger = logger;
    }

    [HttpGet("viber/channel/{id}")]
    public IActionResult GetViberChannelById(int id)
    {
        var viberChannel = _viberChannelService.GetViberChannelById(id);

        if (viberChannel == null)
        {
            return BadRequest();
        }

        return Ok(viberChannel);
    }

    [HttpPost]
    public IActionResult CreateViberChannel(AddViberChannelDto dto)
    {
        var preparedChannel = new ViberChannel
        {
            Name = dto.Name,
            Description = dto.Description,
            Photo = dto.Photo,
            IsPrivate = dto.IsPrivate,
            Website = dto.Website,
            Category = dto.Category,
            Subcategory = dto.Subcategory,
            Location = dto.Location,
            Email = dto.Email,
            IsPublished = dto.IsPublished
        };

        var _viberChannelService.CreateViberChannel(preparedChannel);
        return Ok(preparedChannel);
    }
}
