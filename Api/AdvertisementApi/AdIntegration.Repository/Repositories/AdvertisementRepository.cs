using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Repository.Interfaces;


namespace AdIntegration.Repository.Repositories
{
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
            var deleteAdvertisement = GetAdvertisementById(id);
            _context.Advertisements.Remove(deleteAdvertisement);
            _context.SaveChanges();
            return deleteAdvertisement;
        }

        public Advertisement GetAdvertisementById(int id) => _context.Advertisements.FirstOrDefault(x => x.Id == id);

        public List<Advertisement> GetAllAdvertisements() => _context.Advertisements.ToList();


        public Advertisement UpdateAdvertisementById(int adId, Advertisement inputAdvertisement)
        {
            Advertisement advertisement = GetAdvertisementById(adId);
            _context.Advertisements.Add(inputAdvertisement);
            _context.SaveChanges();
            return inputAdvertisement;
        }
    }
}
