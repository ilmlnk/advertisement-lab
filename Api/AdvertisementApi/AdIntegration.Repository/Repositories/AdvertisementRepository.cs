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

        public void DeleteAdvertisement(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Advertisement> GetAllAdvertisements()
        {
            throw new NotImplementedException();
        }

        public int UpdateAdvertisement(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }
    }
}
