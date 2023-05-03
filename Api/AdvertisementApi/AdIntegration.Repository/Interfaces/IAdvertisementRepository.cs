using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface IAdvertisementRepository
    {
        public Advertisement CreateAdvertisement(Advertisement advertisement);
        public Advertisement DeleteAdvertisement(int id);
        public IEnumerable<Advertisement> GetAllAdvertisements();
        public Advertisement GetAdvertisementById(int id);
        public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement);
    }
}
