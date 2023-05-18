using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities.Viber;

[Table(nameof(ViberUser))]
public class ViberUser : User
{
    public byte[]? Photo { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }
}
