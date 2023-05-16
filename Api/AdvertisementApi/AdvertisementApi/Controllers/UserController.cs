using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.AdvertisementDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AdvertisementService _advertisementService;
        private readonly UserService _userService;

        public UserController() { }

        public UserController(AdvertisementService advertisementService,
            UserService userService)
        {
            _advertisementService = advertisementService;
            _userService = userService;
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
                UserEntity = (SystemUser)dto.UserEntity
            };

            _advertisementService.CreateAdvertisement(createdAdvertisement);
            return Ok(createdAdvertisement);
        }

        [HttpGet("advertisement/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetAdvertisementById(int id)
        {
            var advertisement = _advertisementService.GetAdvertisementById(id);

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
            var advertisement = _advertisementService.GetAdvertisementById(id);

            if (advertisement != null)
            {
                return Ok(_advertisementService.DeleteAdvertisement(id));
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
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return BadRequest("User is not found!");
            }

            return Ok(user);
        }


    }
}
