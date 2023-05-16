using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities.WhatsApp
{
    [Table(nameof(WhatsAppChannel))]
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
