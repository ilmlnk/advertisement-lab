using AdIntegration.Business.Models;
using AdIntegration.Data.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AdIntegration.Repository.Interfaces;
using AdIntegration.Api.Helpers;
using AdIntegration.Data;
using AutoMapper;

namespace AdIntegration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : ControllerBase
    {

        private readonly IUserRepository _repository;
        private readonly JwtService _jwtService;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public UserAccountController(IUserRepository repository, JwtService jwtService, 
            ApplicationDbContext context, IMapper mapper, ILogger logger)
        {
            _repository = repository;
            _jwtService = jwtService;
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(RegisterUserDto dto)
        {
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            
            return Created("success", _repository.AddUser(user));
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(LoginUserDto dto)
        {
            var user = _repository.GetUserByUsername(dto.UserName);
            if (user == null) { 
                return BadRequest(new { message = "Invalid credentials." }); 
            }

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest(new { message = "Invalid credentials." });
            }

            var jwt = _jwtService.Generate(user.UserId);

            return Ok(new { jwt });
            
        }

        [Authorize]
        [HttpPut("update/{id}")]
        public IActionResult UpdateUser(int userId, UpdateUserDto dto)
        {
            var user = _context.Users.Find(userId);

            if (user == null)
            {
                return NotFound("User was not found.");
            }

            _mapper.Map(dto, user);
            _context.SaveChanges();
            return Ok(dto);
        }

        /*[Authorize]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);

            if (user == null)
            {
                return NotFound("User was not found.");
            }

            _repository.DeleteUser(userId);
            return NoContent();
        }*/
    }
}
