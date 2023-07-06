using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Channels;

namespace AdIntegration.Data.Entities.Abstractions
{
    public abstract class Channel
    {
        [Key]
        [Required]
        public int ChannelId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        [Required]
        public bool IsPrivate { get; set; }
        [Required]
        public int ActiveUsersCount { get; set; }
        public int? Posts { get; set; }
    }
}
