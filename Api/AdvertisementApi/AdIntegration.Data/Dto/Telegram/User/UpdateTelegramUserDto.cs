using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.Telegram.User;

public record UpdateTelegramUserDto
{
    public string FirstName;
    public string? LastName;
    public string? Username;
    public string? PhotoUrl;
    public string PhoneNumber;
}
