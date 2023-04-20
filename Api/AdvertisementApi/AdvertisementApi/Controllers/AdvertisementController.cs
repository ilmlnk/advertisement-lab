using AdIntegration.Business.Interfaces;
using AdIntegration.Business.Models.Domain;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Repository.Interfaces;
using AdIntegration.Repository.Repositories;
using AutoMapper;
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
        private readonly ApplicationDbContext _context;
        private readonly IAdvertisementRepository _repository;

        public AdvertisementController(ApplicationDbContext context, IAdvertisementRepository repository) {
            _context = context;
            _repository = repository;
        }

        [Authorize]
        [HttpGet("advertisements")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllAdvertisements()
        {
            return Ok(_context.Advertisements.ToList());
        }


        [Authorize]
        [HttpGet("advertisements/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAdvertisementById(int id) 
        {
            var advertisement = _context.Advertisements.Find(id);

            if (advertisement == null)
            {
                return NotFound("Advertisement was not found.");
            }

            return Ok(advertisement);
        }

        [Authorize]
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult CreateAdvertisement(CreateAdvertisementDto dto)
        {
            var advertisement = new Advertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price,
                DatePosted = DateTime.UtcNow,
                UserEntity = dto.UserEntity
            };

            return Created("success", _repository.CreateAdvertisement(advertisement));
        }

        [Authorize]
        [HttpPut("update/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult UpdateAdvertisementById(int id, UpdateAdvertisementDto dto)
        {
            var foundAdvertisement = _repository.GetAdvertisementById(id);

            if (foundAdvertisement == null)
            {
                return NotFound("Advertisement was not found.");
            }

            var updatedAdvertisement = new Advertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price,
                DatePosted = DateTime.UtcNow,
                UserEntity = dto.UserEntity
            };

            _repository.UpdateAdvertisementById(id, updatedAdvertisement);
            return Ok(updatedAdvertisement);
        }

        [Authorize]
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteAdvertisementById(int id)
        {
            var advertisement = _repository.GetAdvertisementById(id);

            if (advertisement == null)
            {
                return NotFound("Advertisement was not found.");
            }

            _repository.DeleteAdvertisement(id);
            return NoContent();
        }
    }
}
