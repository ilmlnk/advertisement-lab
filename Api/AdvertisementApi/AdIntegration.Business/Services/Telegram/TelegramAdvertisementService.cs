using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Telegram;

public class TelegramAdvertisementService : ITelegramAdvertisementService
{
    private readonly ITelegramAdvertisementRepository _advertisementRepository;

    public TelegramAdvertisementService(ITelegramAdvertisementRepository advertisementRepository)
    {
        _advertisementRepository = advertisementRepository;
    }

    public async Task<TelegramAdvertisement> CreateTelegramAdvertisement(TelegramAdvertisement advertisement)
    {
        var createdAdvertisement = await _advertisementRepository.CreateTelegramAdvertisement(advertisement);
        return createdAdvertisement;
    }

    public async Task<TelegramAdvertisement> DeleteTelegramAdvertisementById(int id)
    {
        var foundAdvertisement = await _advertisementRepository.GetTelegramAdvertisementById(id);
        
        if (foundAdvertisement != null)
        {
            var deletedAdvertisement = await _advertisementRepository.DeleteTelegramAdvertisementById(id);
            return deletedAdvertisement;
        }

        return foundAdvertisement;
    }

    public async Task<IEnumerable<TelegramAdvertisement>> GetAllTelegramAdvertisements()
    {
        var foundAdvertisements = await _advertisementRepository.GetTelegramAdvertisements();
        return foundAdvertisements;
    }

    public async Task<TelegramAdvertisement> GetTelegramAdvertisementById(int id)
    {
        var foundAdvertisement = await _advertisementRepository.GetTelegramAdvertisementById(id);
        return foundAdvertisement;
    }

    public async Task<TelegramAdvertisement> UpdateTelegramAdvertisementById(int id, TelegramAdvertisement advertisement)
    {
        var foundAdvertisement = await _advertisementRepository.GetTelegramAdvertisementById(id);
        
        if (foundAdvertisement != null)
        {
            await _advertisementRepository.UpdateTelegramAdvertisementById(id, advertisement);
        }

        return foundAdvertisement;
    }
}
