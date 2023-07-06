using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Telegram;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Telegram;

public class TelegramChannelRepository : ITelegramChannelRepository
{
    private readonly ApplicationDbContext _context;

    public TelegramChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TelegramChannel> AddTelegramChannel(TelegramChannel telegramChannel)
    {
        await _context.TelegramChannels.AddAsync(telegramChannel);
        await _context.SaveChangesAsync();
        return telegramChannel;
    }

    public async Task<IEnumerable<TelegramChannel>> AddTelegramChannels(List<TelegramChannel> telegramChannels)
    {
        await _context.TelegramChannels.AddRangeAsync(telegramChannels);
        await _context.SaveChangesAsync();
        return telegramChannels;
    }

    public async Task<TelegramChannel> DeleteTelegramChannelById(int id)
    {
        var foundChannel = await GetTelegramChannelById(id);

        if (foundChannel == null)
        {
            return foundChannel;
        }

        _context.TelegramChannels.Remove(foundChannel);
        await _context.SaveChangesAsync();
        return foundChannel;
    }

    public async Task<TelegramChannel> GetTelegramChannelById(int id)
    {
        var foundChannel = await _context.TelegramChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<IEnumerable<TelegramChannel>> GetTelegramChannels()
    {
        var foundChannels = await _context.TelegramChannels.ToListAsync();
        return foundChannels;
    }

    public async Task<TelegramChannel> UpdateTelegramChannelById(int id, TelegramChannel telegramChannel)
    {
        var foundChannel = await GetTelegramChannelById(id);

        if (foundChannel == null)
        {
            return foundChannel;
        }

        _context.TelegramChannels.Update(foundChannel);
        await _context.SaveChangesAsync();
        return foundChannel;
    }
}
