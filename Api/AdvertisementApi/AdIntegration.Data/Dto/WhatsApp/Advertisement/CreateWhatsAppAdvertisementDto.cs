using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.WhatsApp.Advertisement;

public record CreateWhatsAppAdvertisementDto
{
    public string Name;
    public string Topic;
    public string? Description;
    public decimal Price;
    public string SystemUsername;
    public string Platform;
    public Point Location;
}
