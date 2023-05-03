using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto
{
    public class UpdateWhatsAppChannel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[]? Photo { get; set; }
        public bool IsPrivate { get; set; }
        public string Email { get; set; }
        public string UrlAddress { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
    }
}
