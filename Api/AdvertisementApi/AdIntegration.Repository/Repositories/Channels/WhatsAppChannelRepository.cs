using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.Channels;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories.Channels;

public class WhatsAppChannelRepository : IWhatsAppChannelRepository
{
    private readonly ApplicationDbContext _context;

    public WhatsAppChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<WhatsAppChannel> CreateWhatsAppChannel(WhatsAppChannel whatsAppChannel)
    {
        _context.WhatsAppChannels.Add(whatsAppChannel);
        await _context.SaveChangesAsync();
        return whatsAppChannel;
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

    public async Task<WhatsAppChannel> DeleteWhatsAppChannelByLink(string link)
    {
        var foundChannel = await GetWhatsAppChannelByLink(link);
        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Remove(foundChannel);
            await _context.SaveChangesAsync();
        }
        return foundChannel;
    }

    public async Task<IEnumerable<WhatsAppChannel>> GetAllWhatsAppChannels()
    {
        var whatsAppChannels = await _context.WhatsAppChannels.ToListAsync();
        return whatsAppChannels;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelById(int id)
    {
        var foundChannel = await _context.WhatsAppChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link)
    {
        var foundChannel = await _context.WhatsAppChannels
            .FirstOrDefaultAsync(channel => channel.UrlAddress == link);
        return foundChannel;
    }

    public async Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannelsByCategory(string category)
    {
        var foundChannels = await _context.WhatsAppChannels
            .Where(channel =>  channel.Category == category)
            .ToListAsync();
        return foundChannels;
    }

    public async Task<WhatsAppChannel> UpdateWhatsAppChannelById(int id, WhatsAppChannel whatsAppChannel)
    {
        var foundChannel = GetWhatsAppChannelById(id);

        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Update(whatsAppChannel);
            await _context.SaveChangesAsync();
        }

        return whatsAppChannel;
    }

    public async Task<WhatsAppChannel> UpdateWhatsAppChannelByLink(string link, WhatsAppChannel whatsAppChannel)
    {
        var foundChannel = await GetWhatsAppChannelByLink(link);

        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Update(whatsAppChannel);
            _context.SaveChangesAsync();
        }

        return whatsAppChannel;
    }
}
