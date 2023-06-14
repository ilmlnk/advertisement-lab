using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Dto.Viber.Advertisement;
using AdIntegration.Data.Dto.Viber.Channel;
using AdIntegration.Data.Entities.Viber;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AdIntegration.Api.Controllers.Viber;

[ApiController]
[Route("api/[controller]")]
public class ViberAdvertisementController : ControllerBase
{
    private readonly IViberAdvertisementService _advertisementService;
    private readonly ILog log = LogManager.GetLogger(typeof(ViberAdvertisementController));

    public ViberAdvertisementController(IViberAdvertisementService advertisementService)
    {
        _advertisementService = advertisementService;
    }

    [HttpPost("viber/ad/add")]
    public async Task<IActionResult> AddViberAdvertisement([FromForm] AddViberChannelDto dto)
    {
        var preparedAdvertisement = new ViberAdvertisement
        {

        };
        
        var addedAdvertisement = await _advertisementService.CreateViberAdvertisement(preparedAdvertisement);
        return Ok(addedAdvertisement);
    }

    [HttpGet("viber/ad/find/{id}")]
    public async Task<IActionResult> GetViberAdvertisementById(int id)
    {
        var foundAdvetisement = await _advertisementService.GetViberAdvertisementById(id);

        if (foundAdvetisement == null)
        {
            return BadRequest();
        }

        return Ok(foundAdvetisement);
    }

    [HttpGet("viber/ads")]
    public async Task<IActionResult> GetViberAdvertisements()
    {
        var foundAdvertisements = await _advertisementService.GetViberAdvertisements();
        return Ok(foundAdvertisements);
    }

    [HttpPut("viber/channel/update/{id}")]
    public async Task<IActionResult> UpdateViberAdvertisementById(int id, [FromForm] UpdateViberAdvertisementDto dto)
    {
        var foundAdvertisement = await _advertisementService.GetViberAdvertisementById(id);

        if (foundAdvertisement == null)
        {
            return BadRequest();
        }

        var preparedAdvertisement = new ViberAdvertisement
        {

        };

        var updatedAdvertisement = await _advertisementService.UpdateViberAdvertisementById(id, preparedAdvertisement);
        return Ok(updatedAdvertisement);
    }

    [HttpDelete("viber/channel/delete/{id}")]
    public async Task<IActionResult> DeleteViberAdvertisementById(int id)
    {
        var foundAdvertisement = await _advertisementService.GetViberAdvertisementById(id);

        if (foundAdvertisement == null)
        {
            return BadRequest();
        }

        var deletedAdvertisement = await _advertisementService.DeleteViberAdvertisementById(id);
        return Ok(deletedAdvertisement);
    }
}
