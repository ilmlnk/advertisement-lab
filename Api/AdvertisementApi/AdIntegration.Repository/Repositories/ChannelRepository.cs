using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories;

public class ChannelRepository : IChannelRepository
{
    private readonly ApplicationDbContext _context;

    /* Create */
    public Channel CreateChannel(Channel channel)
    {
        _context.Channels.Add(channel);
        _context.SaveChanges();
        return channel;
    }

    /* Get (Receive) */

    public Channel GetChannelById(int id)
    {
        var foundChannel = _context.Channels.Find(id, false);

        if (foundChannel == null)
        {
            throw new InvalidOperationException();
        }

        _context.Channels.Remove(foundChannel);
        _context.SaveChanges();

        return foundChannel;
    }

    public IEnumerable<Channel> GetChannels()
    {
        var channels = _context.Channels.ToList();

        if (channels == null)
        {
            return Enumerable.Empty<Channel>();
        }

        return channels;
    }

    /* Update */
    public object UpdateChannelById(int id, Channel channel)
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
    public Channel DeleteChannelById(int id)
    {
        var foundChannel = _context.Channels.Find(id, false);

        if (foundChannel == null)
        {
            throw new InvalidOperationException();
        }

        _context.Channels.Remove(foundChannel);
        _context.SaveChanges();

        return foundChannel;
    }

    public Channel GetChannelByLink(string channelType, string link)
    {
        return null;
    }

    public IEnumerable<Channel> GetChannelsByCategory(string category)
    {
        throw new NotImplementedException();
    }

    public Channel GetChannelByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TelegramChannel> GetTelegramChannels()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ViberChannel> GetVibersChannels()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<WhatsAppChannel> GetWhatsAppChannels()
    {
        throw new NotImplementedException();
    }

    public Channel GetChannelByName(string name)
    {
        throw new NotImplementedException();
    }
}

