using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.Telegram.Advertisement;

public record CreateTelegramAdvertisementDto
{
    public string Name;
    public string Topic;
    public string Description;
    public decimal Price;
    public string Email;
    public string Username;
}
