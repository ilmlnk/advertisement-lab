using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.WhatsApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.WhatsApp;

public class WhatsAppChannelRepostitory : IWhatsAppChannelRepository
{
    private readonly ApplicationDbContext _context;

    public WhatsAppChannelRepostitory(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<WhatsAppChannel> AddWhatsAppChannel(WhatsAppChannel channel)
    {
        await _context.WhatsAppChannels.AddAsync(channel);
        await _context.SaveChangesAsync();
        return channel;
    }

    public async Task<IEnumerable<WhatsAppChannel>> AddWhatsAppChannels(List<WhatsAppChannel> channels)
    {
        await _context.WhatsAppChannels.AddRangeAsync(channels);
        await _context.SaveChangesAsync();
        return channels;
    }

    public async Task<WhatsAppChannel> DeleteWhatsAppChannelById(int id)
    {
        var foundChannel = await GetWhatsAppChannelById(id);

        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Remove(foundChannel);
            await _context.SaveChangesAsync();
        }

        return foundChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelByEmail(string email)
    {
        var foundChannel = await _context.WhatsAppChannels.FirstOrDefaultAsync(x => x.Email == email);
        return foundChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelById(int id)
    {
        var foundChannel = await _context.WhatsAppChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link)
    {
        var foundChannel = await _context.WhatsAppChannels.FirstOrDefaultAsync(x => x.UrlAddress == link);
        return foundChannel;
    }

    public async Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannels()
    {
        var foundChannels = await _context.WhatsAppChannels.ToListAsync();
        return foundChannels;
    }
}
