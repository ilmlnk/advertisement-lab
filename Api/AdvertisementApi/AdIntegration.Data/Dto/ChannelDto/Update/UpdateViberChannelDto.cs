using NetTopologySuite.Geometries;

namespace AdIntegration.Data.Dto.ChannelDto.Update
{
    public record UpdateViberChannelDto
    {
        public string Name;
        public string Description;
        public byte[] Photo;
        public bool IsPrivate;
        public string ChannelUrl;
        public string Category;
        public string Subcategory;
        public Point Location;
        public string Email;
        public string Website;
    }
}
