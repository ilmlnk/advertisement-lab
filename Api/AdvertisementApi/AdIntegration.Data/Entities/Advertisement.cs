using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities;

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
    public string? Description { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DatePosted { get; set; }
    [Required]
    [ForeignKey(nameof(Advertisement))]
    public int UserId { get; set; }
    [Required]
    public Channel ChannelType { get; set; }

}
