using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities;

[Table(nameof(ActionLog))]
public class ActionLog
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(ActionLog))]
    public int UserId { get; set; }
    [Required]
    public string ActionName { get; set; }
    public string? ActionDescription { get; set; }
    [Required]
    public DateTime Timestamp { get; set; }
}
