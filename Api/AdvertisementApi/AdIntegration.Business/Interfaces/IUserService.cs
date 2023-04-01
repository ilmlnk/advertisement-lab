using AdIntegration.Business.Models;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(RegisterUserDto registerUserDto);
        Task<User> Login(LoginUserDto loginUserDto);
        Task<User> GetUserById(int id);
        Task<User> UpdateUser(int id, UpdateUserDto updateUserDto);
    }
}
