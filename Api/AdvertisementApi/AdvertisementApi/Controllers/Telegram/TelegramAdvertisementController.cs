using AdIntegration.Business.Interfaces;
using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Data.Dto.Telegram.Advertisement;
using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AdIntegration.Api.Controllers.Telegram;

[ApiController]
[Route("api/[controller]")]
public class TelegramAdvertisementController : ControllerBase
{
    private readonly ITelegramAdvertisementService _advertisementService;
    private readonly ISystemUserService _userService;
    private readonly ILog log = LogManager.GetLogger(typeof(TelegramAdvertisementController));

    public TelegramAdvertisementController(ITelegramAdvertisementService advertisementService, ISystemUserService userService) 
    { 
        _advertisementService = advertisementService;
        _userService = userService;
    }

    [HttpGet("telegram/ad/{id}")]
    public async Task<IActionResult> GetTelegramAdvertisementById(int id)
    {
        try
        {
            if (id == 0)
            {
                log.Warn("Invalid ID provided: 0");
                return BadRequest();
            }

            var advertisement = _advertisementService.GetTelegramAdvertisementById(id);

            if (advertisement == null)
            {
                return BadRequest();
            }

            return Ok(advertisement);
        }
        catch (Exception ex)
        {
            log.Error("An error occurred while retrieving the Telegram advertisement", ex);
            return StatusCode(500);
        }
    }

    [HttpPost("telegram/ad/add")]
    public async Task<IActionResult> CreateTelegramAdvertisement([FromBody] CreateTelegramAdvertisementDto dto)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdAdvertisement = new TelegramAdvertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price
            };

            var resultedAdvertisement = _advertisementService.CreateTelegramAdvertisement(createdAdvertisement);
            return Ok(resultedAdvertisement);
        }
        catch (Exception ex)
        {
            log.Error("An error occurred while creating the Telegram advertisement", ex);
            return StatusCode(500);
        }
    }

    [HttpDelete("telegram/ad/delete/{id}")]
    public async Task<IActionResult> DeleteTelegramAdvertisementById(int id)
    {
        try
        {
            var deletedAdvertisement = await _advertisementService.DeleteTelegramAdvertisementById(id);
            return Ok(deletedAdvertisement);
        } catch (Exception ex)
        {
            log.Warn("");
            return BadRequest();
        }
    }

    [HttpPut("telegram/ad/update/{id}")]
    public async Task<IActionResult> UpdateTelegramAdvertisementById(int id, [FromBody] UpdateTelegramAdvertisementDto dto)
    {
        try
        {
            var existingAdvertisement = await _advertisementService.GetTelegramAdvertisementById(id);

            if (existingAdvertisement == null)
            {
                return NotFound();
            }

            var foundUser = await _userService.GetSystemUserByUsername(dto.SystemUsername);

            existingAdvertisement.Name = dto.Name;
            existingAdvertisement.Topic = dto.Topic;
            existingAdvertisement.Price = dto.Price;
            existingAdvertisement.SystemUsername = dto.SystemUsername;

            var uploadedAdvertisement = await _advertisementService.UpdateTelegramAdvertisementById(id, existingAdvertisement);
            return Ok(uploadedAdvertisement);
        } catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpGet("telegram/ads")]
    public async Task<IActionResult> GetTelegramAdvertisements()
    {
        try
        {
            var advertisements = await _advertisementService.GetAllTelegramAdvertisements();
            return Ok(advertisements);
        } catch(Exception ex)
        {
            log.Error(ex);
            return BadRequest(ex.Message);
        }
    }

}
