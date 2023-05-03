using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    [Table(nameof(Advertisement))]
    public class Advertisement
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Topic { get; set; }
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DatePosted { get; set; }
        [Required]
        public User SocialMediaUser { get; set; }
        [Required]
        public SystemUser UserEntity { get; set; }
        [Required]
        public Channel ChannelEntity { get; set; }

    }
}
