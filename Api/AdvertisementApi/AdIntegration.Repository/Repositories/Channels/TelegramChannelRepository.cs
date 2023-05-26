using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Channels;
using Microsoft.EntityFrameworkCore;
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

    public async Task<TelegramChannel> CreateTelegramChannel(TelegramChannel channel)
    {
        _context.TelegramChannels.Add(channel);
        await _context.SaveChangesAsync();
        return channel;
    }

    public async Task<TelegramChannel> DeleteTelegramChannelById(int id)
    {
        var foundChannel = await GetTelegramChannelById(id);

        if (foundChannel != null)
        {
            _context.TelegramChannels.Remove(foundChannel);
            await _context.SaveChangesAsync();
        }
        return foundChannel;
    }

    public async Task<TelegramChannel> DeleteTelegramChannelByLink(string link)
    {
        var foundChannel = await GetTelegramChannelByLink(link);
        if (foundChannel != null)
        {
            _context.TelegramChannels.Remove(foundChannel);
            await _context.SaveChangesAsync();
        }
        return foundChannel;
    }

    public async Task<IEnumerable<TelegramChannel>> GetAllTelegramChannels()
    {
        var channels = await _context.TelegramChannels.ToListAsync();
        return channels;
    }

    public async Task<TelegramChannel> GetTelegramChannelById(int id)
    {
        var foundChannel = await _context.TelegramChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<TelegramChannel> GetTelegramChannelByLink(string link)
    {
        var foundChannel = await _context.TelegramChannels.FirstOrDefaultAsync(channel => channel.ChannelUrl == link);
        return foundChannel;
    }

    public async Task<IEnumerable<TelegramChannel>> GetTelegramChannelsByCategory(string category)
    {
        var foundChannels = await _context.TelegramChannels.Where(channel => channel.Category == category).ToListAsync();
        return foundChannels;
    }

    public async Task<TelegramChannel> UpdateTelegramChannelById(int id, TelegramChannel channel)
    {
        var foundChannel = await GetTelegramChannelById(id);
        if (foundChannel != null)
        {
            _context.TelegramChannels.Update(channel);
            _context.SaveChangesAsync();
        }
        return foundChannel;
    }
}
