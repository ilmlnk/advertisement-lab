using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.AdvertisementDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class AdvertisementController : ControllerBase
{
    private readonly AdvertisementService _advertisementService;
    private readonly ILogger _logger;
    public AdvertisementController(AdvertisementService advertisementService, ILogger logger)
    {
        _advertisementService = advertisementService;
        _logger = logger;
    }


    [HttpGet("advertisements")]
    public IActionResult GetAdvertisements()
    {
        var advertisements = _advertisementService.GetAllAdvertisements();
        _logger.LogInformation("Advertisements were received successfully.");
        return Ok(advertisements);
    }

    [HttpGet("advertisement/{id}")]
    public IActionResult GetAdvertisementById(int id)
    {
        var advertisement = _advertisementService.GetAdvertisementById(id);

        if (advertisement == null)
        {
            _logger.LogError($"Advertisement with ID {id} was not found.");
            return BadRequest();
        }

        return Ok(advertisement);
    }

    [HttpPost("advertisement/create")]
    public IActionResult CreateAdvertisement(CreateAdvertisementDto dto)
    {
        var createAdvertisement = new Advertisement
        {
            Name = dto.Name,
            Topic = dto.Topic,
            Description = dto.Description,
            Price = dto.Price,
            UserEntity = (SystemUser)dto.UserEntity,
            ChannelType = dto.ChannelType,
        };

        var uploadAdvertisement = _advertisementService.CreateAdvertisement(createAdvertisement);
        _logger.LogInformation("Advertisement created and uploaded successfully.");
        return Ok(uploadAdvertisement);
    }

    [HttpDelete("advertisement/delete/{id}")]
    public IActionResult DeleteAdvertisementById(int id)
    {
        var foundAdvertisement = _advertisementService.GetAdvertisementById(id);

        if (foundAdvertisement != null)
        {
            _advertisementService.DeleteAdvertisement(id);
            _logger.LogInformation($"Advertisement with ID {id} successfully deleted.");
            return Ok(foundAdvertisement);
        }
        else
        {
            _logger.LogError($"Error deleting advertisement with ID: {id}.");
            return BadRequest();
        }
    }

    [HttpPut("advertisement/update/{id}")]
    public IActionResult UpdateAdvertisementById(int id, UpdateAdvertisementDto dto)
    {
        var foundAdvertisement = _advertisementService.GetAdvertisementById(id);
        if (foundAdvertisement != null)
        {
            var updatedAdvertisement = new Advertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price,
                DatePosted = DateTime.Now,
                UserEntity = (SystemUser)dto.UserEntity,
                ChannelType = dto.ChannelType
            };

            _advertisementService.UpdateAdvertisementById(id, updatedAdvertisement);
            return Ok(updatedAdvertisement);
        } else
        {
            return BadRequest();
        }
    }
}