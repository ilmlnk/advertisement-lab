using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;

namespace AdIntegration.Data.Entities.WhatsApp
{
    [Table("WhatsAppUsers")]
    public class WhatsAppUser : User
    {
        [Required]
        public override string UserName { get; set; }
        public string? PhotoUrl { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
