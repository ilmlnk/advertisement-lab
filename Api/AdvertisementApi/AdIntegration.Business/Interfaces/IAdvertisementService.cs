using AdIntegration.Data;
using AdIntegration.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IAdvertisementService
    {
        public int CreateAdvertisement(Advertisement advertisement);
        public int UpdateAdvertisementById(int id, Advertisement advertisement);
        public int DeleteAdvertisement(int id);
        public IEnumerable<Advertisement> GetAllAdvertisements();
        public Advertisement GetAdvertisementById(int id);
    }
}
