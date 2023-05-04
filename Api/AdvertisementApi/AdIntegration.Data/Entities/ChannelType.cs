using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    public enum ChannelType
    {
        [EnumMember(Value = "telegram")]
        Telegram = 1,

        [EnumMember(Value = "whatsapp")]
        WhatsApp,

        [EnumMember(Value = "viber")]
        Viber
    }
}
