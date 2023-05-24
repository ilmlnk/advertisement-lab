using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;


namespace AdIntegration.Repository.Repositories;

public class AdvertisementRepository : IAdvertisementRepository
{
    private readonly ApplicationDbContext _context;

    public AdvertisementRepository(ApplicationDbContext context) => _context = context;

    public Advertisement CreateAdvertisement(Advertisement advertisement)
    {
        _context.Advertisements.Add(advertisement);
        _context.SaveChanges();
        return advertisement;
    }

    public Advertisement DeleteAdvertisement(int id)
    {
        var advertisement = _context.Advertisements.Find(id);

        if (advertisement != null)
        {
            _context.Advertisements.Remove(advertisement);
            _context.SaveChanges();
            return advertisement;
        }
        return null;
    }

    public Advertisement GetAdvertisementById(int id)
    {
        var advertisement = _context.Advertisements.Find(id);

        if (advertisement != null)
        {
            return advertisement;
        }
        return null;
    }

    public Advertisement UpdateAdvertisementById(int adId, Advertisement inputAdvertisement)
    {
        var advertisement = _context.Advertisements.Find(adId);

        if (advertisement != null)
        {
            _context.Advertisements.Update(inputAdvertisement);
            _context.SaveChanges();
            return inputAdvertisement;
        }

        return null;
    }

    public IEnumerable<Advertisement> GetAllAdvertisements()
    {
        var advertisements = _context.Advertisements.ToList();
        return advertisements;
    }
}
