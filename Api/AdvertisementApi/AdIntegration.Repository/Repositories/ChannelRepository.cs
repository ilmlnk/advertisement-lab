using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories
{
    public class ChannelRepository<T, V> : IChannelRepository<T, V> where T : User where V : Channel<T>
    {
        private readonly ApplicationDbContext<T, V> _context;

        /* Create */
        public V CreateChannel<V>(V channel) where V : Channel<T>
        {
            _context.Channels.Add(channel);
            _context.SaveChanges();
            return channel;
        }

        /* Get (Receive) */

        public V GetChannelById<V>(int id) where V : Channel<T>
        {
            var foundChannel = _context.Channels.Find(id, false);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.Channels.Remove(foundChannel);
            _context.SaveChanges();

            return (V) foundChannel;
        } 

        public IEnumerable<V> GetChannels<V>() where V : Channel<T>
        {
            var channels = _context.Channels.ToList();

            if (channels == null)
            {
                return Enumerable.Empty<V>();
            }

            return (IEnumerable<V>) channels;
        }

        /* Update */
        public object UpdateChannelById<V>(int id, V channel) where V : Channel<T>
        {
            var foundChannel = _context.Channels.Find(id);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.Channels.Update(channel);
            _context.SaveChanges();

            var response = new
            {
                Old = foundChannel,
                New = channel
            };

            return response;
        }

        /* Delete */
        public V DeleteChannelById<V>(int id) where V : Channel<T>
        {
            var foundChannel = _context.Channels.Find(id, false);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.Channels.Remove(foundChannel);
            _context.SaveChanges();

            return (V)foundChannel;
        }

        public V GetChannelByLink<V>(string link) where V : Channel<T>
        {
            throw new NotImplementedException();
        }

        public IEnumerable<V> GetChannelsByCategory<V>(string category) where V : Channel<T>
        {
            throw new NotImplementedException();
        }

        public V GetChannelByEmail<V>(string email) where V : Channel<T>
        {
            throw new NotImplementedException();
        }

    }
}
