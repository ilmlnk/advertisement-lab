using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.ChannelDto.Update
{
    public record UpdateWhatsAppChannel
    {
        public string Name;
        public string Description;
        public byte[]? Photo;
        public bool IsPrivate;
        public string Email;
        public string UrlAddress;
        public string Category;
        public string Subcategory;
    }
}
