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

public class ViberAdvertisementRepository : IViberAdvertisementRepository
{
    private readonly ApplicationDbContext _context;

    public ViberAdvertisementRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ViberAdvertisement> AddViberAdvertisement(ViberAdvertisement viberAdvertisement)
    {
        await _context.ViberAdvertisements.AddAsync(viberAdvertisement);
        await _context.SaveChangesAsync();
        return viberAdvertisement;
    }

    public async Task<ViberAdvertisement> DeleteViberAdvertisementById(int id)
    {
        var foundAdvertisement = await GetViberAdvertisementById(id);

        if (foundAdvertisement != null)
        {
            _context.ViberAdvertisements.Remove(foundAdvertisement);
            await _context.SaveChangesAsync();
        }

        return foundAdvertisement;
    }

    public async Task<ViberAdvertisement> GetViberAdvertisementById(int id)
    {
        var foundAdvertisement = await _context.ViberAdvertisements.FindAsync(id);
        return foundAdvertisement;
    }

    public async Task<IEnumerable<ViberAdvertisement>> GetViberAdvertisements()
    {
        var foundAdvertisements = await _context.ViberAdvertisements.ToListAsync();
        return foundAdvertisements;
    }

    public async Task<ViberAdvertisement> UpdateViberAdvertisementById(int id, ViberAdvertisement viberAdvertisement)
    {
        var foundAdvertisement = await GetViberAdvertisementById(id);

        if (foundAdvertisement != null)
        {
            _context.ViberAdvertisements.Update(viberAdvertisement);
            await _context.SaveChangesAsync();
        }

        return viberAdvertisement;
    }
}
