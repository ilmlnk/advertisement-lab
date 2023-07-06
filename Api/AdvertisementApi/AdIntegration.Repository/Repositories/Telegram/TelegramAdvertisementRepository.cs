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

public class TelegramAdvertisementRepository : ITelegramAdvertisementRepository
{
    private readonly ApplicationDbContext _context;

    public TelegramAdvertisementRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TelegramAdvertisement> CreateTelegramAdvertisement(TelegramAdvertisement advertisement)
    {
        await _context.TelegramAdvertisements.AddAsync(advertisement);
        await _context.SaveChangesAsync();
        return advertisement;
    }

    public async Task<TelegramAdvertisement> DeleteTelegramAdvertisementById(int id)
    {
        var foundAdvertisement = await GetTelegramAdvertisementById(id);

        if (foundAdvertisement == null) 
        {
            return foundAdvertisement;
        }

        _context.TelegramAdvertisements.Remove(foundAdvertisement);
        await _context.SaveChangesAsync();
        return foundAdvertisement;
    }

    public async Task<TelegramAdvertisement> GetTelegramAdvertisementById(int id)
    {
        var foundAdvertisement = await _context.TelegramAdvertisements.FindAsync(id);
        return foundAdvertisement;
    }

    public async Task<IEnumerable<TelegramAdvertisement>> GetTelegramAdvertisements()
    {
        var foundAdvertisements = await _context.TelegramAdvertisements.ToListAsync();
        return foundAdvertisements;
    }

    public async Task<TelegramAdvertisement> UpdateTelegramAdvertisementById(int id, TelegramAdvertisement advertisement)
    {
        var foundAdvertisement = await GetTelegramAdvertisementById(id);

        if (foundAdvertisement == null) 
        {
            return foundAdvertisement;
        }

        _context.TelegramAdvertisements.Update(advertisement);
        await _context.SaveChangesAsync();
        return advertisement;
    }
}
