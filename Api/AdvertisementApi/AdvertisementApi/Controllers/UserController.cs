using Microsoft.AspNetCore.Mvc;
using AdIntegration.Data;
using Microsoft.AspNet.SignalR;
using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;

namespace AdIntegration.Api.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController<T, V> : ControllerBase where T : User where V : Channel<T>
    {
        private readonly ApplicationDbContext<T, V> _context;
        private readonly UserRepository _userRepository;
        private readonly AdvertisementRepository<T, V> _advertisementRepository;

        public UserController(ApplicationDbContext<T, V> context, 
            UserRepository userRepository,
            AdvertisementRepository<T, V> advertisementRepository)
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
            var createdAdvertisement = new Advertisement<T, V>
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
            return Ok(_advertisementRepository.GetAdvertisementById<T, V>(id));
        }

        [HttpDelete("advertisement/delete")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult DeleteAdvertisement(int id)
        {
            return Ok(_advertisementRepository.DeleteAdvertisement<T, V>(id));
        }

        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetAllUsers() 
        { 
            return Ok(_userRepository.GetAllUsers());
        }

        [HttpGet("users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetUserById(int id)
        {
            return Ok(_userRepository.GetUserById(id));
        }
        

    }
}
