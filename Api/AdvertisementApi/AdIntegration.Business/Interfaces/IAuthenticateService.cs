using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CreateUser(RegisterUserDto registerUserDto);
        public IActionResult AuthenticateUser(LoginUserDto loginUserDto);
    }
}
