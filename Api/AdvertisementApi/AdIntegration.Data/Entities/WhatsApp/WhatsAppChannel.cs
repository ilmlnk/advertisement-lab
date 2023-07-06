using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;

namespace AdIntegration.Data.Entities.WhatsApp
{
    [Table("WhatsAppChannels")]
    public class WhatsAppChannel : Channel
    {
        [Required]
        public int BusinessProfileId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public string UrlAddress { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Subcategory { get; set; }
    }
}
