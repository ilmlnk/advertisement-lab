using AdIntegration.Data.Entities;
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
    public class UserAccountController<T, V> : ControllerBase where T : User where V : Channel<T>
    {

        private readonly IUserRepository<T> _userRepository;
        private readonly JwtService _jwtService;
        private readonly ApplicationDbContext<T, V> _context;
        private readonly IMapper _mapper;

        public UserAccountController(IUserRepository<T> userRepository, JwtService jwtService, 
            ApplicationDbContext<T, V> context, IMapper mapper)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
            _context = context;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(RegisterUserDto dto)
        {
            var user = new SystemUser
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
            
            return Created("success", _userRepository.AddUser(user));
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(LoginUserDto dto)
        {
            var user = _userRepository.GetUserByUsername(dto.UserName);
            if (user == null) { 
                return BadRequest(new { message = "Invalid credentials." }); 
            }

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
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
    }
}
