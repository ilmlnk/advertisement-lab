using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.WhatsApp.User;

public record AddWhatsAppUserDto
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string? PhotoUrl;
    public string PhoneNumber;
}
