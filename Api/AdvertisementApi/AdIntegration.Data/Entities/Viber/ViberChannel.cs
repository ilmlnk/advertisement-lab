using AdIntegration.Data.Entities.Abstractions;
using Microsoft.AspNet.SignalR;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace AdIntegration.Data.Entities.Viber
{
    [Table("ViberChannels")]
    public class ViberChannel : Channel
    {
        [Required]
        public string AuthToken { get; set; }
        public string? BackgroundPhotoUrl { get; set; }
        [Required]
        public string ChannelUrl { get; set; }
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
        public string? WebsiteUrl { get; set; }
        [Required]
        public bool IsPublished { get; set; }
    }
}
