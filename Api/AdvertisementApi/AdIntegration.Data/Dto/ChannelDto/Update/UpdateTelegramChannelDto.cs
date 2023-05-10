using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.ChannelDto.Update
{
    public record UpdateTelegramChannelDto
    {
        public string Name;
        public string Description;
        public byte[] Photo;
        public bool IsPrivate;
        public string ChannelUrl;
        public string InviteLink;
    }
}
