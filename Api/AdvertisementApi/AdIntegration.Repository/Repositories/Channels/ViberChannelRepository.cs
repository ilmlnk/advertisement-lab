using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Channels;
using Microsoft.EntityFrameworkCore;
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

    public async Task<ViberChannel> CreateViberChannel(ViberChannel viberChannel)
    {
        _context.ViberChannels.Add(viberChannel);
        await _context.SaveChangesAsync();
        return viberChannel;
    }

    public async Task<ViberChannel> DeleteViberChannelById(int id)
    {
        var foundChannel = await GetViberChannelById(id);

        if (foundChannel != null)
        {
            _context.ViberChannels.Remove(foundChannel);
            await _context.SaveChangesAsync();
        }
        return foundChannel;
    }

    public async Task<IEnumerable<ViberChannel>> GetAllViberChannels()
    {
        var viberChannels = await _context.ViberChannels.ToListAsync();
        return viberChannels;
    }

    public async Task<ViberChannel> GetViberChannelById(int id)
    {
        var foundChannel =  await _context.ViberChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<IEnumerable<ViberChannel>> GetViberChannelsByCategory(string category)
    {
        var foundChannels = await _context.ViberChannels
            .Where(channel => channel.Category == category)
            .ToListAsync();
        return foundChannels;
    }

    public async Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel viberChannel)
    {
        var foundChannel = await GetViberChannelById(id);

        if (foundChannel != null)
        {
            _context.ViberChannels.Update(viberChannel);
            await _context.SaveChangesAsync();
        }

        return viberChannel;
    }
}
