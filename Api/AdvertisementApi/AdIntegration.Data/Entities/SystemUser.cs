using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    [Table(nameof(SystemUser))]
    public class SystemUser : User
    {
        [Required]
        public string Email { get; set; }
    }
}
