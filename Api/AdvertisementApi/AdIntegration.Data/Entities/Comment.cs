using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    [Table(nameof(Comment))]
    public class Comment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public uint? Likes { get; set; }
        [Required]
        public User CreatedBy { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
