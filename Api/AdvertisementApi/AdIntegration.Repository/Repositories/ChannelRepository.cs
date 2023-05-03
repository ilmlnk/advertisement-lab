using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly ApplicationDbContext _context;

        /* Create */
        public Channel CreateChannel(Channel channel)
        {
            _context.SocialChannels.Add(channel);
            _context.SaveChanges();
            return channel;
        }

        /* Get (Receive) */

        public Channel GetChannelById(int id)
        {
            var foundChannel = _context.SocialChannels.Find(id, false);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.SocialChannels.Remove(foundChannel);
            _context.SaveChanges();

            return foundChannel;
        } 

        public IEnumerable<Channel> GetChannels()
        {
            var channels = _context.SocialChannels.ToList();

            if (channels == null)
            {
                return Enumerable.Empty<Channel>();
            }

            return channels;
        }

        /* Update */
        public object UpdateChannelById(int id, Channel channel)
        {
            var foundChannel = _context.SocialChannels.Find(id);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.SocialChannels.Update(channel);
            _context.SaveChanges();

            var response = new
            {
                Old = foundChannel,
                New = channel
            };

            return response;
        }

        /* Delete */
        public Channel DeleteChannelById(int id)
        {
            var foundChannel = _context.SocialChannels.Find(id, false);

            if (foundChannel == null)
            {
                throw new InvalidOperationException();
            }

            _context.SocialChannels.Remove(foundChannel);
            _context.SaveChanges();

            return foundChannel;
        }

        public Channel GetChannelByLink(string link)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Channel> GetChannelsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Channel GetChannelByEmail(string email)
        {
            throw new NotImplementedException();
        }

    }
}
