using AdIntegration.Data.Entities;

namespace AdIntegration.Data.Dto.AdvertisementDto;

public record CreateAdvertisementDto
{
    public string Name;
    public string Topic;
    public string? Description;
    public decimal Price;
    public int UserId;
    public Channel ChannelType;
}
