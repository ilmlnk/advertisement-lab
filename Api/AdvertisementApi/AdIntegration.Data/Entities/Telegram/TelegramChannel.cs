using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;

namespace AdIntegration.Data.Entities.Telegram
{
    [Table("TelegramChannels")]
    public class TelegramChannel : Channel
    {
        [Required]
        public string ChannelUrl { get; set; }
        [Required]
        public bool IsSuperGroup { get; set; }
        [Required]
        public bool IsBroadcast { get; set; }
        [Required]
        public string InviteLink { get; set; }
    }
}
