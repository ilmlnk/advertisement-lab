using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;

namespace AdIntegration.Data.Entities.Telegram;

[Table("TelegramAdvertisements")]
public class TelegramAdvertisement : Advertisement
{

    public int TelegramUserAdminId { get; set; }
    public TelegramUser TelegramUserAdmin { get; set; }
    [Required]
    public string Platform { get; set; }
}
