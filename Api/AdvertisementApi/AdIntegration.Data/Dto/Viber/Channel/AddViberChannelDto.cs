using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.Viber.Channel;

public record AddViberChannelDto
{
    public string Name;
    public string? Description;
    public string? PhotoUrl;
    public string? BackgroundPhotoUrl;
    public bool IsPrivate;
    public string ChannelUrl;
    public string Category;
    public string Subcategory;
    public Point? Location;
    public string? Email;
    public string WebsiteUrl;
    public bool IsPublished;
}
