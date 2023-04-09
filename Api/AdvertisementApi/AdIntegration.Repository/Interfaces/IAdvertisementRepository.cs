using AdIntegration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface IAdvertisementRepository
    {
        public int CreateAdvertisement(Advertisement advertisement);
        public int DeleteAdvertisement(int id);
        public IEnumerable<Advertisement> GetAllAdvertisements();
        public Advertisement GetAdvertisementById(int id);
        public int UpdateAdvertisementById(int id, Advertisement advertisement);
    }
}
