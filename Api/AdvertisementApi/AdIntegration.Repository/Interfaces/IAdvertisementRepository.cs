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
        public int UpdateAdvertisement(Advertisement advertisement);
        public void DeleteAdvertisement(int id);
        public IEnumerable<Advertisement> GetAllAdvertisements();

    }
}
