using AdIntegration.Data;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdIntegration.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvertisementService _advertisementService;

        public AdvertisementController(IAdvertisementService advertisementService) => _advertisementService = advertisementService;

        [Authorize]
        [HttpGet]
        public IActionResult GetAdvertisements()
        {
            var advertisements = _advertisementService.Advertisements.ToList();
            return Ok();
        }
    }
}
