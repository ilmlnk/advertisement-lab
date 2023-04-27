using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class ChannelService<T, V> : IChannelService<T, V> where T : User where V : Channel<T>
    {
        private readonly IChannelRepository<T, V> _channelRepository;
        public ChannelService(IChannelRepository<T, V> channelRepository) 
        {
            _channelRepository = channelRepository;
        }
        public V CreateChannel(V channel)
        {
            var createdChannel = _channelRepository.CreateChannel<V>(channel);
            if (createdChannel == null)
            {
                throw new ArgumentException();
            }
            return createdChannel;
        }

        public V DeleteChannelById(int channelId)
        {
            return _channelRepository.DeleteChannelById<V>(channelId);
        }

        public IEnumerable<V> GetAllChannels()
        {
            return _channelRepository.GetChannels<V>();
        }

        public V GetChannelById(int channelId)
        {
            return _channelRepository.GetChannelById<V>(channelId);
        }

        public object UpdateChannelById(int id, V channel)
        {
            var foundChannel = _channelRepository.GetChannelById<V>(id);
            var updatedChannel = _channelRepository.UpdateChannelById<V>(id, channel);
            
            var response =  new
            {
                Old = foundChannel,
                New = updatedChannel
            };

            return response;
        }
    }
}
