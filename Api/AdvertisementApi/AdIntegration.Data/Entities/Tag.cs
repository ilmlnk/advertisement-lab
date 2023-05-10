using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    [Table("TaskTag")]
    public class Tag
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TaskId { get; set; }
        [Required]
        public AdminTask Task { get; set; }
    }
}
