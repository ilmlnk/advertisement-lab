using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.Viber.User;

public record UpdateViberUserDto
{
    public string FirstName;
    public string? LastName;
    public string UserName;
    public string? PhotoUrl;
    public string PhoneNumber;
}
