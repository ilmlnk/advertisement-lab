using AdIntegration.Business.Interfaces;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Repository.Interfaces;
using AutoMapper;
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
        private readonly ApplicationDbContext _context;

        public AdvertisementService(IAdvertisementRepository advertisementRepository, ApplicationDbContext context) 
        { 
            _advertisementRepository = advertisementRepository;
            _context = context;
        }
        public Advertisement CreateAdvertisement(Advertisement advertisement) => _advertisementRepository.CreateAdvertisement(advertisement);
        public Advertisement DeleteAdvertisement(int id) => _advertisementRepository.DeleteAdvertisement(id);
        public Advertisement GetAdvertisementById(int id) => _advertisementRepository.GetAdvertisementById(id);
        public List<Advertisement> GetAllAdvertisements() => _advertisementRepository.GetAllAdvertisements();
        public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement)
        {
            _advertisementRepository.UpdateAdvertisementById(id, advertisement);
            return advertisement;
        }
    }
}
