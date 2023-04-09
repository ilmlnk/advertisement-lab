using AdIntegration.Business.Models;
using AdIntegration.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IAuthenticateService
    {
        public string GenerateToken(User user);
        public Task<User> CreateUser(RegisterUserDto registerUserDto);
        public Task<User> AuthenticateUser(LoginUserDto loginUserDto);
    }
}
