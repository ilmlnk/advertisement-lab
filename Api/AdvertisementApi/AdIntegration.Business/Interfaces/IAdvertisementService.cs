using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IAdvertisementService
    {
        public Advertisement CreateAdvertisement(Advertisement advertisement);
        public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement);
        public Advertisement DeleteAdvertisement(int id);
        public IEnumerable<Advertisement> GetAllAdvertisements();
        public Advertisement GetAdvertisementById(int id);
    }
}
