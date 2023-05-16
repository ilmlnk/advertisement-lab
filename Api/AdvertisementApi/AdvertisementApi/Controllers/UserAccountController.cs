using AdIntegration.Data;
using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AdIntegration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserRepository _userRepository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserAccountController(IConfiguration configuration,
            UserRepository userRepository,
            ApplicationDbContext context,
            IMapper mapper)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _context = context;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(RegisterUserDto dto)
        {
            var existingUser = _userRepository.GetUserByUsername(dto.UserName);

            if (existingUser != null)
            {
                return StatusCode(409, "User with this username is already registered!");
            }
            else
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
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(LoginUserDto dto)
        {
            var user = _userRepository.GetUserByUsername(dto.UserName);

            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return NotFound();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JWT:ExpireDays"]));


            var token = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                claims,
                expires: expires,
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
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
