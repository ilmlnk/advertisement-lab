using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IChannelService<T, V> where T : User where V : Channel<T>
    {
        public V CreateChannel(V channel);
        public object UpdateChannelById(int id, V channel);
        public V GetChannelById(int channelId);
        public IEnumerable<V> GetAllChannels();
        public V DeleteChannelById(int channelId);
    }
}
