using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities;

[Table(nameof(Comment))]
public class Comment
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Text { get; set; }
    public uint? Likes { get; set; }
    [ForeignKey(nameof(Comment))]
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime CreateDate { get; set; }
}
