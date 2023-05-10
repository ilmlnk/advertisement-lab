using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.UserDto
{
    public record RegisterUserDto
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string UserName;
        public string Password;

    }
}
