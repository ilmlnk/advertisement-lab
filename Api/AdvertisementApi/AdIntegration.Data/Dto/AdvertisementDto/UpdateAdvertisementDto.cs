using AdIntegration.Data.Entities;

namespace AdIntegration.Data.Dto.AdvertisementDto;

public record UpdateAdvertisementDto
{
    public string Name;
    public string Topic;
    public string? Description;
    public decimal Price;
    public User UserEntity;
    public Channel ChannelType;
}
