using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;

namespace AdIntegration.Data.Entities;

[Table("SystemUsers")]
public class SystemUser : User
{
    [Required]
    public bool IsAdmin { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public override string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public bool IsOnline { get; set; }
}
