using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IChannelService
    {
        public Channel CreateChannel(Channel channel);
        public object UpdateChannelById(int id, Channel channel);
        public Channel GetChannelById(int channelId);
        public IEnumerable<Channel> GetAllChannels();
        public Channel DeleteChannelById(int channelId);
    }
}
