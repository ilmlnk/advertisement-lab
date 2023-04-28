using Microsoft.AspNet.SignalR;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace AdIntegration.Data.Entities.Viber
{
    [Table(nameof(ViberChannel<T, V>))]
    public class ViberChannel<T, V> : Channel<T> where T : User where V : Channel<T>
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
        public Point? Location { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        public Url? Website { get; set; }
        [Required]
        public List<string> EventTypes { get; set; }
        [Required]
        public bool IsPublished { get; set; }
    }
}
