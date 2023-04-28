using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.WhatsApp
{
    public class WhatsAppChannel : Channel<User>
    {   
        public int BusinessProfileId { get; set; }
        public string Email { get; set; }
        public Url UrlAddress { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
    }
}
