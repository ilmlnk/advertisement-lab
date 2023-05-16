using AdIntegration.Data;
using AdIntegration.Data.Dto.AdvertisementDto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly AdvertisementRepository _advertisementRepository;
        private readonly UserRepository _userRepository;
        public AdminController(ApplicationDbContext context,
            AdvertisementRepository advertisementRepository,
            UserRepository userRepository)
        {
            _context = context;
            _advertisementRepository = advertisementRepository;
            _userRepository = userRepository;
        }

        [HttpGet("users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null)
            {
                return NotFound("User was not found");
            }

            return Ok(user);
        }

        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUsers()
        {
            var users = _userRepository.GetAllUsers();

            var response = new
            {
                Users = users,
                Success = true
            };

            return Ok(response);
        }

        /*
         * Delete User by Id
         */
        [HttpDelete("delete/{id}"), ActionName("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null)
            {
                return NotFound("User was not found.");
            }

            var deletedUser = _userRepository.DeleteUser(id);

            var response = new
            {
                User = deletedUser,
                Success = true
            };

            return Ok(response);
        }

        [HttpDelete("ads/delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteAdvertisement(int id)
        {
            var ad = _context.Advertisements.Find(id);
            if (ad == null)
            {
                return NotFound();
            }

            _advertisementRepository.DeleteAdvertisement(id);

            return Ok();
        }

        [HttpPut("ads/update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateAdvertisement(int id, UpdateAdvertisementDto dto)
        {
            var existingAd = _context.Advertisements.FirstOrDefault(x => x.Id == id);
            if (existingAd == null)
            {
                return NotFound();
            }

            var editAd = new Advertisement
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Price = dto.Price,
                DatePosted = DateTime.Now,
                UserEntity = (SystemUser)dto.UserEntity
            };

            _advertisementRepository.UpdateAdvertisementById(id, editAd);
            return Ok();
        }

        [HttpGet("ads")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllAdvertisements()
        {
            return Ok(_advertisementRepository.GetAllAdvertisements());
        }

        [HttpGet("ads/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAdvertisementById(int id)
        {
            return Ok(_advertisementRepository.GetAdvertisementById(id));
        }


    }
}
