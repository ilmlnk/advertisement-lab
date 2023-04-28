using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.Telegram
{
    [Table(nameof(TelegramChannel<T, V>))]
    public class TelegramChannel<T, V> : Channel<T> where T : User where V : Channel<T>
    {
        [Required]
        public Url ChannelUrl { get; set; }
        [Required]
        public bool IsSuperGroup { get; set; }
        [Required]
        public bool IsBroadcast { get; set; }
        [Required]
        public string InviteLink { get; set; }
    }
}
