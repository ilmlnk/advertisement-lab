using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.Telegram
{
    public class TelegramUser : User
    {
        public string? Username { get; set; }
        public byte[]? Photo { get; set; }
        public string PhoneNumber { get; set; }
    }
}
