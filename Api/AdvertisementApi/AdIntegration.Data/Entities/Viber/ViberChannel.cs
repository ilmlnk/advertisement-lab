using Microsoft.AspNet.SignalR;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace AdIntegration.Data.Entities.Viber
{
    [Table(nameof(ViberChannel))]
    public class ViberChannel : Channel
    {
        [Required]
        public string AuthToken { get; set; }
        public byte[]? Background { get; set; }
        [Required]
        [StringLength(100)]
        public string Category { get; set; }
        [Required]
        [StringLength(100)]
        public string Subcategory { get; set; }
        [NotMapped]
        public Point? Location { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        public string? Website { get; set; }
        [Required]
        public List<string> EventTypes { get; set; }
        [Required]
        public bool IsPublished { get; set; }
    }
}
