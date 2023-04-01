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
        public int CreateAdvertisement(CreateAdvertisementDto createAdvertisementDto);
        public int UpdateAdvertisement(UpdateAdvertisementDto updateAdvertisementDto);
        public int UpdateAdvertisementById(int id, UpdateAdvertisementDto updateAdvertisementDto);
        public int DeleteAdvertisement(int id);
        public List<Advertisement> GetAllAdvertisements();
        public Advertisement GetAdvertisementById(int id);
    }
}
