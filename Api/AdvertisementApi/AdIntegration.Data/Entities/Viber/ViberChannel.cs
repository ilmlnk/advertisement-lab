using NetTopologySuite.Geometries;
using System.Security.Policy;

namespace AdIntegration.Data.Entities.Viber
{
    public class ViberChannel : Channel<User>
    {
        public string AuthToken { get; set; }
        public Url Background { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public Point Location { get; set; }
        public string Email { get; set; }
        public Url Website { get; set; }
        public List<string> EventTypes { get; set; }
        public bool IsPublished { get; set; }
    }
}
