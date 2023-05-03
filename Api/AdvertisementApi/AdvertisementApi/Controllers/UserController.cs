using Microsoft.AspNetCore.Mvc;
using AdIntegration.Data;
using Microsoft.AspNet.SignalR;
using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using Microsoft.Owin.Security.Provider;

namespace AdIntegration.Api.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserRepository _userRepository;
        private readonly AdvertisementRepository _advertisementRepository;

        public UserController(ApplicationDbContext context, 
            UserRepository userRepository,
            AdvertisementRepository advertisementRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _advertisementRepository = advertisementRepository;
        }

        [HttpPost("advertisement/create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult CreateAdvertisement(CreateAdvertisementDto dto)
        {
            var createdAdvertisement = new Advertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price,
                DatePosted = DateTime.UtcNow,
                UserEntity = (SystemUser) dto.UserEntity
            };

            _context.Advertisements.Add(createdAdvertisement);
            _context.SaveChanges();
            return Ok(createdAdvertisement);
        }

        [HttpGet("advertisement/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetAdvertisementById(int id)
        {
            var advertisement = _advertisementRepository.GetAdvertisementById(id);

            if (advertisement == null)
            {
                return BadRequest("Advertisement was not found!");
            }

            return Ok(advertisement);
        }

        [HttpDelete("advertisement/delete")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult DeleteAdvertisement(int id)
        {
            var advertisement = _advertisementRepository.GetAdvertisementById(id);

            if (advertisement != null)
            {
                return Ok(_advertisementRepository.DeleteAdvertisement(id));
            } 
            else
            {
                return BadRequest("Advertisement cannot be deleted!");
            }
            
        }

        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetAllUsers() 
        { 
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null)
            {
                return BadRequest("User is not found!");
            }

            return Ok(user);
        }
        

    }
}
