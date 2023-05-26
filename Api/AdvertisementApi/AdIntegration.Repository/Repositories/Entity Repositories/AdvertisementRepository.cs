using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class AdvertisementRepository : IAdvertisementRepository
{
    private readonly ApplicationDbContext _context;

    public AdvertisementRepository(ApplicationDbContext context) => _context = context;

    public async Task<Advertisement> CreateAdvertisement(Advertisement advertisement)
    {
        _context.Advertisements.Add(advertisement);
        await _context.SaveChangesAsync();
        return advertisement;
    }

    public async Task<Advertisement> DeleteAdvertisement(int id)
    {
        var advertisement = await _context.Advertisements.FindAsync(id);

        if (advertisement != null)
        {
            _context.Advertisements.Remove(advertisement);
            await _context.SaveChangesAsync();
        }
        return advertisement;
    }

    public async Task<Advertisement> GetAdvertisementById(int id)
    {
        var advertisement = await _context.Advertisements.FindAsync(id);
        return advertisement;
    }

    public async Task<Advertisement> UpdateAdvertisementById(int adId, Advertisement inputAdvertisement)
    {
        var advertisement = await _context.Advertisements.FindAsync(adId);

        if (advertisement != null)
        {
            _context.Advertisements.Update(inputAdvertisement);
            await _context.SaveChangesAsync();
        }

        return inputAdvertisement;
    }

    public async Task<IEnumerable<Advertisement>> GetAllAdvertisements()
    {
        var advertisements = await _context.Advertisements.ToListAsync();
        return advertisements;
    }
}
