using AdIntegration.Data.Dto.User;
using AdIntegration.Data.Entities.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces;

public interface IAuthenticateService
{
    public string GenerateToken(User user);
    public Task<User> CreateUser(RegisterSystemUserDto registerUserDto);
    public Task<User> AuthenticateUser(LoginSystemUserDto loginUserDto);
}
