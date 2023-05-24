using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Channels;

public class ViberChannelRepository : IViberChannelRepository
{
    private readonly ApplicationDbContext _context;

    public ViberChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public ViberChannel CreateViberChannel(ViberChannel viberChannel)
    {
        _context.ViberChannels.Add(viberChannel);
        _context.SaveChanges();
        return viberChannel;
    }

    public ViberChannel DeleteViberChannelById(int id)
    {
        var foundChannel = GetViberChannelById(id);

        if (foundChannel != null)
        {
            _context.ViberChannels.Remove(foundChannel);
            _context.SaveChanges();
            return foundChannel;
        }
        return null;
    }

    public IEnumerable<ViberChannel> GetAllViberChannels()
    {
        var viberChannels = _context.ViberChannels.ToList();
        return viberChannels;
    }

    public ViberChannel GetViberChannelById(int id)
    {
        var foundChannel = _context.ViberChannels.Find(id);
        if (foundChannel != null)
        {
            return foundChannel;
        }
        return null;
    }

    public IEnumerable<ViberChannel> GetViberChannelsByCategory(string category)
    {
        var foundChannels = _context.ViberChannels.Where(channel => channel.Category == category).ToList();
        return foundChannels;
    }

    public ViberChannel UpdateViberChannelById(int id, ViberChannel viberChannel)
    {
        var foundChannel = GetViberChannelById(id);

        if (foundChannel != null)
        {
            _context.ViberChannels.Update(viberChannel);
            return viberChannel;
        }

        return null;
    }
}
