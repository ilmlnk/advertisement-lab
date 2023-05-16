using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Business.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IChannelRepository _channelRepository;
        public ChannelService(IChannelRepository channelRepository)
        {
            _channelRepository = channelRepository;
        }
        public Channel CreateChannel(Channel channel)
        {
            var createdChannel = _channelRepository.CreateChannel(channel);
            if (createdChannel == null)
            {
                throw new ArgumentException();
            }
            return createdChannel;
        }

        public Channel DeleteChannelById(int channelId)
        {
            return _channelRepository.DeleteChannelById(channelId);
        }

        public IEnumerable<Channel> GetAllChannels()
        {
            return _channelRepository.GetChannels();
        }

        public Channel GetChannelById(int channelId)
        {
            return _channelRepository.GetChannelById(channelId);
        }

        public object UpdateChannelById(int id, Channel channel)
        {
            var foundChannel = _channelRepository.GetChannelById(id);
            var updatedChannel = _channelRepository.UpdateChannelById(id, channel);

            var response = new
            {
                Old = foundChannel,
                New = updatedChannel
            };

            return response;
        }
    }
}
