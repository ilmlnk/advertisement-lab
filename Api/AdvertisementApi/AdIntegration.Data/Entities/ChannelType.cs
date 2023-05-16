using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities
{
    [Table(nameof(ChannelType))]
    public class ChannelType
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
