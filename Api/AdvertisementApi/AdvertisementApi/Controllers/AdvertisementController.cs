using AdIntegration.Business.Interfaces;
using AdIntegration.Business.Models.Domain;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdIntegration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvertisementService _advertisementService;

        public AdvertisementController(IAdvertisementService advertisementService) => _advertisementService = advertisementService;

        [Authorize]
        [HttpGet("advertisements")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetAdvertisements()
        {
            return Ok(_advertisementService.GetAllAdvertisements());
        }


        [Authorize]
        [HttpGet("advertisement/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetAdvertisementById(int id) 
        {
            return Ok(_advertisementService.GetAdvertisementById(id));
        }

        [Authorize]
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult CreateAdvertisement(Advertisement advertisement)
        {
            return Ok(_advertisementService.CreateAdvertisement(advertisement));
        }

        [Authorize]
        [HttpPost("update/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult UpdateAdvertisementById(int id, Advertisement advertisement)
        {
            return Ok(_advertisementService.UpdateAdvertisementById(id, advertisement));
        }

        [Authorize]
        [HttpPost("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult DeleteAdvertisementById(int id)
        {
            return Ok(_advertisementService.DeleteAdvertisement(id));
        }
    }
}
