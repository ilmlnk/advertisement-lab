using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Dto.WhatsApp.Advertisement;
using AdIntegration.Data.Entities.WhatsApp;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AdIntegration.Api.Controllers.WhatsApp;

[ApiController]
[Route("api/[controller]")]
public class WhatsAppAdvertisementController : ControllerBase
{
    private readonly IWhatsAppAdvertisementService _advertisementService;
    private readonly ILog log = LogManager.GetLogger(typeof(WhatsAppAdvertisementController));

    public WhatsAppAdvertisementController(IWhatsAppAdvertisementService advertisementService)
    {
        _advertisementService = advertisementService;
    }

    [HttpGet("whatsapp/ad/find/{id}")]
    public async Task<IActionResult> GetWhatsAppAdvertisementById(int id)
    {
        var foundUser = await _advertisementService.GetWhatsAppAdvertisementById(id);

        if (foundUser == null)
        {
            log.Warn($"User with ID {id} was not found.");
            return BadRequest();
        }

        return Ok(foundUser);
    }

    [HttpGet("whatsapp/ads")]
    public async Task<IActionResult> GetWhatsAppAdvertisements()
    {
        var foundUsers = await _advertisementService.GetWhatsAppAdvertisements();
        return Ok(foundUsers);
    }

    [HttpPost("whatsapp/ad/create")]
    public async Task<IActionResult> AddWhatsAppAdvertisement([FromBody] CreateWhatsAppAdvertisementDto dto)
    {
        try
        {
            var preparedAdvertisement = new WhatsAppAdvertisement
            {

            };

            var addedAdvertisement = await _advertisementService.AddWhatsAppAdvertisement(preparedAdvertisement);
            return Ok(addedAdvertisement);
        } catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpDelete("whatsapp/ad/delete/{id}")]
    public async Task<IActionResult> DeleteWhatsAppAdvertisementById(int id)
    {
        try
        {
            var foundAdvertisement = await _advertisementService.GetWhatsAppAdvertisementById(id);

            if (foundAdvertisement == null)
            {
                return BadRequest();
            }

            var deletedAdvertisement = await _advertisementService.DeleteWhatsAppAdvertisementById(id);
            
            return Ok(deletedAdvertisement);
        } catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpPut("whatsapp/ad/update/{id}")]
    public async Task<IActionResult> UpdateWhatsAppAdvertisementById(int id, [FromBody] UpdateWhatsAppAdvertisementDto dto)
    {
        try
        {
            return Ok();
        } catch (Exception ex)
        {
            log.Error(ex);
            return BadRequest();
        }
    }

}
