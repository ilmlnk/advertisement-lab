using AdIntegration.Business.Interfaces;
using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
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

        public Advertisement CreateAdvertisement(Advertisement advertisement)
        {
            var createdAdvertisement = _advertisementRepository.CreateAdvertisement(advertisement);

            if (createdAdvertisement == null)
            {
                throw new InvalidOperationException();
            }

            return createdAdvertisement;
        }

        public Advertisement DeleteAdvertisement(int id)
        {
            var deletedAdvertisement = _advertisementRepository.DeleteAdvertisement(id);

            if (deletedAdvertisement == null)
            {
                throw new InvalidOperationException();
            }

            return deletedAdvertisement;
        }

        public Advertisement GetAdvertisementById(int id)
        {
            var adverisement = _advertisementRepository.GetAdvertisementById(id);
            
            if (adverisement == null)
            {
                throw new InvalidOperationException();
            }

            return adverisement;
        }

        public IEnumerable<Advertisement> GetAllAdvertisements()
        {
            var advertisements = _advertisementRepository.GetAllAdvertisements();
            
            if (advertisements == null)
            {
                throw new InvalidOperationException();
            }

            return advertisements;
        }

        public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement)
        {
            var updatedAdvertisement = _advertisementRepository.UpdateAdvertisementById(id, advertisement);

            if (updatedAdvertisement == null)
            {
                throw new InvalidOperationException();
            }

            return advertisement;
        }
    }
}
