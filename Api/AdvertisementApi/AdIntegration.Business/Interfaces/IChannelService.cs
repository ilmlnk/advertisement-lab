using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces;

public interface IChannelService
{
    public Channel CreateChannel(Channel channel);
    public object UpdateChannelById(int id, Channel channel);
    public Channel GetChannelById(int channelId);
    public IEnumerable<Channel> GetAllChannels();
    public Channel DeleteChannelById(int channelId);
}
