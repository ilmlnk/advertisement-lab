using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities;

[Table(nameof(Post))]
public class Post
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Text { get; set; }
    public List<byte[]>? Photos { get; set; }
    [Required]
    public SystemUser CreatedByUser { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public int? Reposts { get; set; }
    public IEnumerable<Comment>? Comments { get; set; }
}
