using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.Telegram
{
    public class TelegramChannel : Channel<User>
    {
        public Url ChannelUrl { get; set; }
        public bool IsSuperGroup { get; set; }
        public bool IsBroadcast { get; set; }
        public string InviteLink { get; set; }
    }
}
