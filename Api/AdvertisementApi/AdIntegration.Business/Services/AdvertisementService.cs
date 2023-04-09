using AdIntegration.Business.Interfaces;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly IAdvertisementRepository _advertisementRepository;

        public AdvertisementService(IAdvertisementRepository advertisementRepository) => _advertisementRepository = advertisementRepository;
        public int CreateAdvertisement(Advertisement advertisement) => _advertisementRepository.CreateAdvertisement(advertisement);
        public int DeleteAdvertisement(int id) => _advertisementRepository.DeleteAdvertisement(id);
        public Advertisement GetAdvertisementById(int id) => _advertisementRepository.GetAdvertisementById(id);
        public IEnumerable<Advertisement> GetAllAdvertisements() => _advertisementRepository.GetAllAdvertisements();
        public int UpdateAdvertisementById(int id, Advertisement advertisement)
        {
            _advertisementRepository.UpdateAdvertisementById(id, advertisement);
            return id;
        }
    }
}
