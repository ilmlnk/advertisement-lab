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

public class WhatsAppAdvertisementRepository : IWhatsAppAdvertisementRepository
{
    private readonly ApplicationDbContext _context;

    public WhatsAppAdvertisementRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<WhatsAppAdvertisement> CreateWhatsAppAdvertisement(WhatsAppAdvertisement whatsAppAdvertisement)
    {
        await _context.WhatsAppAdvertisements.AddAsync(whatsAppAdvertisement);
        await _context.SaveChangesAsync();
        return whatsAppAdvertisement;
    }

    public async Task<WhatsAppAdvertisement> DeleteWhatsAppAdvertisementById(int id)
    {
        var foundAdvertisement = await GetWhatsAppAdvertisementById(id);

        if (foundAdvertisement != null)
        {
            _context.WhatsAppAdvertisements.Remove(foundAdvertisement);
            await _context.SaveChangesAsync();
        }

        return foundAdvertisement;
    }

    public async Task<WhatsAppAdvertisement> GetWhatsAppAdvertisementById(int id)
    {
        var foundAdvertisement = await _context.WhatsAppAdvertisements.FindAsync(id);
        return foundAdvertisement;
    }

    public async Task<IEnumerable<WhatsAppAdvertisement>> GetWhatsAppAdvertisements()
    {
        var foundAdvertisements = await _context.WhatsAppAdvertisements.ToListAsync();
        return foundAdvertisements;
    }

    public async Task<WhatsAppAdvertisement> UpdateWhatsAppAdvertisementById(int id, WhatsAppAdvertisement whatsAppAdvertisement)
    {
        var foundAdvertisement = await GetWhatsAppAdvertisementById(id);

        if (foundAdvertisement != null)
        {
            _context.WhatsAppAdvertisements.Update(whatsAppAdvertisement);
            await _context.SaveChangesAsync();
        }

        return whatsAppAdvertisement;
    }
}
