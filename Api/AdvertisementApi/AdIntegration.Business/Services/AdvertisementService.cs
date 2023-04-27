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
    public class AdvertisementService<T, V> : IAdvertisementService<T, V> 
        where T : User 
        where V : Channel<T>
    {
        private readonly IAdvertisementRepository<T, V> _advertisementRepository;
        private readonly ApplicationDbContext<T, V> _context;

        public AdvertisementService(IAdvertisementRepository<T, V> advertisementRepository, ApplicationDbContext<T, V> context) 
        { 
            _advertisementRepository = advertisementRepository;
            _context = context;
        }

        public Advertisement<T, V> CreateAdvertisement<T, V>(Advertisement<T, V> advertisement) 
            where T : User 
            where V : Channel<T>
        {
            var createdAdvertisement = _advertisementRepository.CreateAdvertisement(advertisement);

            if (createdAdvertisement == null)
            {
                throw new InvalidOperationException();
            }

            return createdAdvertisement;
        }

        public Advertisement<T, V> DeleteAdvertisement<T, V>(int id)
            where T : User
            where V : Channel<T>
        {
            var deletedAdvertisement = _advertisementRepository.DeleteAdvertisement<T, V>(id);

            if (deletedAdvertisement == null)
            {
                throw new InvalidOperationException();
            }

            return deletedAdvertisement;
        }

        public Advertisement<T, V> GetAdvertisementById<T, V>(int id)
            where T : User
            where V : Channel<T>
        {
            var adverisement = _advertisementRepository.GetAdvertisementById<T, V>(id);
            
            if (adverisement == null)
            {
                throw new InvalidOperationException();
            }

            return adverisement;
        }

        public IEnumerable<Advertisement<T, V>> GetAllAdvertisements<T, V>()
            where T : User
            where V : Channel<T>
        {
            var advertisements = _advertisementRepository.GetAllAdvertisements<T, V>();
            
            if (advertisements == null)
            {
                throw new InvalidOperationException();
            }

            return advertisements;
        }

        public Advertisement<T, V> UpdateAdvertisementById<T, V>(int id, Advertisement<T, V> advertisement)
            where T : User
            where V : Channel<T>
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
