using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IChannelRepository
    {
        /* Create */
        public Channel CreateChannel(Channel channel);
        /* Update */
        public object UpdateChannelById(int id, Channel channel);
        /* Get */
        public Channel GetChannelById(int id);
        public Channel GetChannelByLink(string link);
        public IEnumerable<Channel> GetChannelsByCategory(string category);
        public Channel GetChannelByEmail(string email);
        public IEnumerable<Channel> GetChannels();
        /* Delete */
        public Channel DeleteChannelById(int id);

    }
}
