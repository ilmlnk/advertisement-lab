using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.WhatsApp
{
    [Table(nameof(WhatsAppChannel<T, V>))]
    public class WhatsAppChannel<T, V> : Channel<T> where T : User where V : Channel<T>
    {
        [Required]
        public int BusinessProfileId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public Url UrlAddress { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Subcategory { get; set; }
    }
}
