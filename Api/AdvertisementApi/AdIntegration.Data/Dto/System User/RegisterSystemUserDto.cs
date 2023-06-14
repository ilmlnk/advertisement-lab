using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.User;

public record RegisterSystemUserDto
{
    public string FirstName;
    public string LastName;
    public bool IsAdmin;
    public string Email;
    public string UserName;
    public string Password;
}
