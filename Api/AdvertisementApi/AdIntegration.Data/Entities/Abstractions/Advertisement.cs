using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities.Abstractions;

public abstract class Advertisement
{
    [Key]
    [Required]
    public int AdvertisementId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Topic { get; set; }
    public string Description { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    /*[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DatePosted { get; set; }*/
    [Required]
    public int SystemUserId { get; set; }
    [Required]
    public string SystemUsername { get; set; }

    [ForeignKey("SystemUserId")]
    public SystemUser SystemUserEntity { get; set; }

}
