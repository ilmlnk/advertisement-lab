using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.Telegram
{
    [Table(nameof(TelegramUser))]
    public class TelegramUser : User
    {
        public override string? UserName { get; set; }
        public byte[]? Photo { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
