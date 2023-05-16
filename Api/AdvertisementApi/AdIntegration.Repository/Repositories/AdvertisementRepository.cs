using AdIntegration.Data;
using AdIntegration.Data.Entities;
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
            var advertisement = _context.Advertisements.Find(id);
            if (advertisement != null)
            {
                _context.Advertisements.Remove(advertisement);
                _context.SaveChanges();
            }
            return advertisement;
        }

        public Advertisement GetAdvertisementById(int id)
        {
            var advertisement = _context.Advertisements.Find(id);

            if (advertisement == null)
            {
                throw new ArgumentException($"Advertisement with ID {id} not found.");
            }

            return advertisement;
        }

        public Advertisement UpdateAdvertisementById(int adId, Advertisement inputAdvertisement)
        {
            var advertisement = _context.Advertisements.Find(adId);

            if (advertisement == null)
            {
                throw new ArgumentException($"Advertisement with ID {adId} not found.");
            }

            advertisement.Name = inputAdvertisement.Name;
            advertisement.Topic = inputAdvertisement.Topic;
            advertisement.Description = inputAdvertisement.Description;
            advertisement.Price = inputAdvertisement.Price;
            advertisement.ChannelType = inputAdvertisement.ChannelType;

            _context.SaveChanges();

            return inputAdvertisement;
        }

        public IEnumerable<Advertisement> GetAllAdvertisements()
        {
            var advertisements = _context.Advertisements.ToList();

            /*if (advertisements == null)
            {
                throw new InvalidOperationException();
            }*/

            return advertisements;
        }
    }
}
