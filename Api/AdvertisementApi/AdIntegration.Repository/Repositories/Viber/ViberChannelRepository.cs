using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Viber;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Viber;

public class ViberChannelRepository : IViberChannelRepository
{
    private readonly ApplicationDbContext _context;

    public ViberChannelRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ViberChannel> AddViberChannel(ViberChannel channel)
    {
        await _context.ViberChannels.AddAsync(channel);
        await _context.SaveChangesAsync();
        return channel;
    }

    public async Task<IEnumerable<ViberChannel>> AddViberChannels(List<ViberChannel> viberChannels)
    {
        await _context.ViberChannels.AddRangeAsync(viberChannels);
        return viberChannels;
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

    public async Task<ViberChannel> GetViberChannelByEmail(string email)
    {
        var foundChannel = await _context.ViberChannels.FirstOrDefaultAsync(x => x.Email == email);
        return foundChannel;
    }

    public async Task<ViberChannel> GetViberChannelById(int id)
    {
        var foundChannel = await _context.ViberChannels.FindAsync(id);
        return foundChannel;
    }

    public async Task<IEnumerable<ViberChannel>> GetViberChannels()
    {
        var foundChannels = await _context.ViberChannels.ToListAsync();
        return foundChannels;
    }

    public async Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel channel)
    {
        var foundChannel = await GetViberChannelById(id);

        if (foundChannel != null)
        {
            _context.ViberChannels.Update(channel);
            await _context.SaveChangesAsync();
        }

        return channel;
    }
}
