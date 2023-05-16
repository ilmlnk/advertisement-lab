using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities.WhatsApp
{
    [Table(nameof(WhatsAppUser))]
    public class WhatsAppUser : User
    {
        public byte[]? Photo { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
