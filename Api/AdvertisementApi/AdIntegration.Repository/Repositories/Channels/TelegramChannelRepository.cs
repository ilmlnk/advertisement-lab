using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Channels;

public class TelegramChannelRepository : ITelegramChannelRepository
{
    private readonly ApplicationDbContext _context;

    public TelegramChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public TelegramChannel CreateTelegramChannel(TelegramChannel channel)
    {
        _context.TelegramChannels.Add(channel);
        _context.SaveChanges();
        return channel;
    }

    public TelegramChannel DeleteTelegramChannelById(int id)
    {
        var foundChannel = GetTelegramChannelById(id);

        if (foundChannel != null)
        {
            _context.TelegramChannels.Remove(foundChannel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }

    public TelegramChannel DeleteTelegramChannelByLink(string link)
    {
        var foundChannel = GetTelegramChannelByLink(link);
        if (foundChannel != null)
        {
            _context.TelegramChannels.Remove(foundChannel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }

    public IEnumerable<TelegramChannel> GetAllTelegramChannels()
    {
        var channels = _context.TelegramChannels.ToList();
        return channels;
    }

    public TelegramChannel GetTelegramChannelById(int id)
    {
        var foundChannel = _context.TelegramChannels.Find(id);
        if (foundChannel != null)
        {
            return foundChannel;
        }
        return null;
    }

    public TelegramChannel GetTelegramChannelByLink(string link)
    {
        var foundChannel = _context.TelegramChannels.FirstOrDefault(channel => channel.ChannelUrl == link);
        if (foundChannel != null)
        {
            return foundChannel;
        }
        return null;
    }

    public IEnumerable<TelegramChannel> GetTelegramChannelsByCategory(string category)
    {
        var foundChannels = _context.TelegramChannels.Where(channel => channel.Category == category).ToList();
        return foundChannels;
    }

    public TelegramChannel UpdateTelegramChannelById(int id, TelegramChannel channel)
    {
        var foundChannel = GetTelegramChannelById(id);
        if (foundChannel != null)
        {
            _context.TelegramChannels.Update(channel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }
}
