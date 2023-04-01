using AdIntegration.Business.Interfaces;
using AdIntegration.Business.Models;
using AdIntegration.Data.Dto;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpPost("register")]
        public async Task<IActionResult> CreateUser([FromBody] RegisterUserDto registerDto)
        {
            try
            {
                User user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    Email = registerDto.Email,
                    Username = registerDto.Username,
                    Password = registerDto.Password
                };

                return Ok();
            } 
            
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
            
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                User user = await _userService.GetUserById(id);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserDto userUpdateDto)
        {
            try
            {
                User updatedUser = await _userService.UpdateUser(id, userUpdateDto);
                return Ok(updatedUser);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
