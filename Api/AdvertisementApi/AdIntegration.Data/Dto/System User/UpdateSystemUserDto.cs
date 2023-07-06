using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.User;

public record UpdateSystemUserDto
{
    public string FirstName;
    public string LastName;
    public string Email;
    public string Username;
    public string Password;
}
