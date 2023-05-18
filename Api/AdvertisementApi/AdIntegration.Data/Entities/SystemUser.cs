using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities;

[Table(nameof(SystemUser))]
public class SystemUser : User
{
    [Required]
    public string Email { get; set; }
    [Required]
    public bool IsOnline { get; set; }
}
