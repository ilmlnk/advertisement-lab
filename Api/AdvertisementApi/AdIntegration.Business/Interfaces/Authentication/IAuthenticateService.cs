using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces.Authentication;

public interface IAuthenticateService
{
    public string GenerateToken(User user);
    public Task<User> CreateUser(RegisterUserDto registerUserDto);
    public Task<User> AuthenticateUser(LoginUserDto loginUserDto);
}
