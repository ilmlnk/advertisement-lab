using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdIntegration.Data.Entities.Abstractions;
using NetTopologySuite.Geometries;

namespace AdIntegration.Data.Entities.Viber;

[Table("ViberAdvertisements")]
public class ViberAdvertisement : Advertisement
{
    public ViberUser ViberUserAdmin { get; set; }
    public int ViberUserId { get; set; }
    [NotMapped]
    public Point Location { get; set; }

}
