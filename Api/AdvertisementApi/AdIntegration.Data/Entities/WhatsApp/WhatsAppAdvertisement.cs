using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;
using NetTopologySuite.Geometries;

namespace AdIntegration.Data.Entities.WhatsApp;

[Table("WhatsAppAdvertisements")]
public class WhatsAppAdvertisement : Advertisement
{
    
    public int WhatsAppUserId { get; set; }
    public WhatsAppUser User { get; set; }
    public string Platform { get; set; }
    [NotMapped]
    public Point Location { get; set; }

}
