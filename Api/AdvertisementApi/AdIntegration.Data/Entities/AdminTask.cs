using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities
{

    [Table("Task")]
    public class AdminTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Topic { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Status { get; set; }
        public int? Priority { get; set; }
        [Required]
        public DateTime CreatedAtDate { get; set; }
        public DateTime? DueToDate { get; set; }
        [Required]
        public SystemUser AssignedTo { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Comment>? Comments { get; set; }

    }
}
