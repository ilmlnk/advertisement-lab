using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;


namespace AdIntegration.Repository.Repositories
{
    public class AdvertisementRepository<T, V> : IAdvertisementRepository<T, V> where T : User where V : Channel<T>
    {
        private readonly ApplicationDbContext<T, V> _context;

        public AdvertisementRepository(ApplicationDbContext<T, V> context) => _context = context;

        public Advertisement<T, V> CreateAdvertisement<T, V>(Advertisement<T, V> advertisement) 
            where T : User where V: Channel<T>
        {
            _context.Set<Advertisement<T, V>>().Add(advertisement);
            _context.SaveChanges();
            return advertisement;
        }

        public Advertisement<T, V>? DeleteAdvertisement<T, V>(int id) where T : User where V : Channel<T>
        {
            var advertisement = _context.Set<Advertisement<T, V>>().Find(id);
            if (advertisement != null)
            {
                _context.Set<Advertisement<T, V>>().Remove(advertisement);
                _context.SaveChanges();
            }
            return advertisement;
        }

        public Advertisement<T, V>? GetAdvertisementById<T, V>(int id) where T : User where V : Channel<T>
        {
            var advertisement = _context.Set<Advertisement<T, V>>().FirstOrDefault(a => a.Id == id && typeof(T).IsAssignableFrom(a.SocialMediaUser.GetType()) && typeof(V).IsAssignableFrom(a.Channel.GetType()));

            if (advertisement == null)
            {
                throw new ArgumentException($"Advertisement with ID {id} not found.");
            }

            return advertisement;
        }

        public Advertisement<T, V> UpdateAdvertisementById<T, V>(int adId, Advertisement<T, V> inputAdvertisement) where T : User where V : Channel<T>
        {
            var advertisement = _context.Set<Advertisement<T, V>>().FirstOrDefault(a => a.Id == adId 
            && typeof(T).IsAssignableFrom(a.SocialMediaUser.GetType()) 
            && typeof(V).IsAssignableFrom(a.Channel.GetType()));

            if (advertisement == null)
            {
                throw new ArgumentException($"Advertisement with ID {adId} not found.");
            }

            advertisement.Name = inputAdvertisement.Name;
            advertisement.Topic = inputAdvertisement.Topic;
            advertisement.Description = inputAdvertisement.Description;
            advertisement.Price = inputAdvertisement.Price;
            advertisement.Channel = inputAdvertisement.Channel;
            advertisement.SocialMediaUser = inputAdvertisement.SocialMediaUser;

            _context.SaveChanges();

            return inputAdvertisement;
        }

        public IEnumerable<Advertisement<T, V>>? GetAllAdvertisements<T, V>() where T : User where V : Channel<T>
        {
            var advertisements = _context.Set<Advertisement<T, V>>()
                .Where(a => typeof(T)
                .IsAssignableFrom(a.SocialMediaUser.GetType()) 
            && typeof(V).IsAssignableFrom(a.Channel.GetType()));

            if (advertisements == null)
            {
                throw new InvalidOperationException();
            }

            return advertisements;
        }
    }
}
