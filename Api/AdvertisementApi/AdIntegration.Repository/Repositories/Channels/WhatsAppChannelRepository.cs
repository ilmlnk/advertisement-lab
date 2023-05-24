using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Channels;

public class WhatsAppChannelRepository : IWhatsAppChannelRepository
{
    private readonly ApplicationDbContext _context;

    public WhatsAppChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public WhatsAppChannel CreateWhatsAppChannel(WhatsAppChannel whatsAppChannel)
    {
        _context.WhatsAppChannels.Add(whatsAppChannel);
        _context.SaveChanges();
        return whatsAppChannel;
    }

    public WhatsAppChannel DeleteWhatsAppChannelById(int id)
    {
        var foundChannel = GetWhatsAppChannelById(id);
        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Remove(foundChannel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }

    public WhatsAppChannel DeleteWhatsAppChannelByLink(string link)
    {
        var foundChannel = GetWhatsAppChannelByLink(link);
        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Remove(foundChannel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }

    public IEnumerable<WhatsAppChannel> GetAllWhatsAppChannels()
    {
        var whatsAppChannels = _context.WhatsAppChannels.ToList();
        return whatsAppChannels;
    }

    public WhatsAppChannel GetWhatsAppChannelById(int id)
    {
        var foundChannel = _context.WhatsAppChannels.Find(id);

        if (foundChannel != null)
        {
            return foundChannel;
        }

        return null;
    }

    public WhatsAppChannel GetWhatsAppChannelByLink(string link)
    {
        var foundChannel = _context.WhatsAppChannels.FirstOrDefault(channel => channel.UrlAddress == link);
        
        if (foundChannel != null)
        {
            return foundChannel;
        }

        return null;
    }

    public IEnumerable<WhatsAppChannel> GetWhatsAppChannelsByCategory(string category)
    {
        var foundChannels = _context.WhatsAppChannels.Where(channel =>  channel.Category == category).ToList();
        return foundChannels;
    }

    public WhatsAppChannel UpdateWhatsAppChannelById(int id, WhatsAppChannel whatsAppChannel)
    {
        var foundChannel = GetWhatsAppChannelById(id);

        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Update(whatsAppChannel);
            _context.SaveChanges();
            return whatsAppChannel;
        }

        return null;
    }

    public WhatsAppChannel UpdateWhatsAppChannelByLink(string link, WhatsAppChannel whatsAppChannel)
    {
        var foundChannel = GetWhatsAppChannelByLink(link);

        if (foundChannel != null)
        {
            _context.WhatsAppChannels.Update(whatsAppChannel);
            _context.SaveChanges();
            return whatsAppChannel;
        }

        return null;
    }
}
