using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto
{
    public class UpdateTelegramChannelDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public bool IsPrivate { get; set; }
        public Url ChannelUrl { get; set; }
        public string InviteLink { get; set; }
    }
}
