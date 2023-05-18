using AdIntegration.Business.Exceptions;
using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AdIntegration.Business.Services;

public class AuthenticateService : IAuthenticateService
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public AuthenticateService(IConfiguration configuration, UserManager<User> userManager, IMapper mapper)
    {
        _configuration = configuration;
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<User> AuthenticateUser(LoginUserDto loginUserDto)
    {
        var user = await _userManager.FindByNameAsync(loginUserDto.UserName);
        if (user == null)
        {
            throw new NotFoundException("Username not found");
        }

        if (await _userManager.CheckPasswordAsync(user, loginUserDto.Password))
        {
            return user;
        }
        throw new AuthenticateException("Incorrect password");
    }


    public async Task<User> CreateUser(RegisterUserDto registerUserDto)
    {
        var user = _mapper.Map<User>(registerUserDto);
        var result = await _userManager.CreateAsync(user, registerUserDto.Password);
        if (!result.Succeeded)
        {
            throw new Exception();
        }
        return user;
    }

    public string GenerateToken(User user)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var tokenOptions = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: new[]
            {
                new Claim(ClaimTypes.NameIdentifier, GenerateToken(user)),
                new Claim(nameof(user.UserName), user.UserName),
                new Claim(nameof(user.FirstName), user.FirstName),
                new Claim(nameof(user.LastName), user.LastName)
            },
            expires: DateTime.Now.AddHours(6),
            signingCredentials: signingCredentials
            );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        return tokenString;
    }
}
