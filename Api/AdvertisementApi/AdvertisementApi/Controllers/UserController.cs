using Microsoft.AspNetCore.Mvc;
using AdIntegration.Data;
using Microsoft.AspNet.SignalR;

namespace AdIntegration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById(int id) 
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound("User was not found");
            }

            return Ok(user);
        }

        [Authorize]
        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();

            var response = new
            {
                Users = users,
                Success = true
            };

            return Ok(response);
        }

        [HttpDelete("delete/{id}"), ActionName("Delete")]
        public IActionResult DeleteUserById(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound("User was not found.");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            var response = new
            {
                User = user,
                Success = true
            };

            return Ok(response);
        }
    }
}
