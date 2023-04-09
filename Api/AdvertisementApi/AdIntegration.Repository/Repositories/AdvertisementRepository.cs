using AdIntegration.Data;
using AdIntegration.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories
{
    public class AdvertisementRepository : IAdvertisementRepository
    {
        private readonly ApplicationDbContext _context;

        public AdvertisementRepository(ApplicationDbContext context) => _context = context;

        public int CreateAdvertisement(Advertisement advertisement)
        {
            _context.Advertisements.Add(advertisement);
            _context.SaveChanges();
            return advertisement.Id;
        }

        public int DeleteAdvertisement(int id)
        {
            _context.Advertisements.Remove(GetAdvertisementById(id));
            _context.SaveChanges();
            return id;
        }

        public Advertisement GetAdvertisementById(int id) => _context.Advertisements.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Advertisement> GetAllAdvertisements() => _context.Advertisements.ToList();


        public int UpdateAdvertisementById(int adId, Advertisement inputAdvertisement)
        {
            Advertisement advertisement = GetAdvertisementById(adId);
            _context.Advertisements.Add(inputAdvertisement);
            _context.SaveChanges();
            return advertisement.Id;
        }
    }
}
