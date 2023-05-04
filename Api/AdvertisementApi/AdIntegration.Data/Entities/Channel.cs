using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Channels;

namespace AdIntegration.Data.Entities
{
    public abstract class Channel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Photo { get; set; }
        [Required]
        public bool IsPrivate { get; set; }
        [Required]
        public int ActiveUsers { get; set; }
        public int? Posts { get; set; }
        [Required]
        public List<User> UserAdmins { get; set; }
        public string ChannelType { get; set; }
    }
}
