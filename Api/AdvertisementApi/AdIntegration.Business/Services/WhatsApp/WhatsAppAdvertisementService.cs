using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.WhatsApp;

public class WhatsAppAdvertisementService : IWhatsAppAdvertisementService
{
    private readonly IWhatsAppAdvertisementRepository _advertisementRepository;

    public WhatsAppAdvertisementService(IWhatsAppAdvertisementRepository advertisementRepository)
    {
        _advertisementRepository = advertisementRepository;
    }

    public async Task<WhatsAppAdvertisement> AddWhatsAppAdvertisement(WhatsAppAdvertisement advertisement)
    {
        var createdAdvertisement = await _advertisementRepository.CreateWhatsAppAdvertisement(advertisement);
        return createdAdvertisement;
    }

    public async Task<WhatsAppAdvertisement> DeleteWhatsAppAdvertisementById(int id)
    {
        var deletedAdvertisement = await _advertisementRepository.DeleteWhatsAppAdvertisementById(id);
        return deletedAdvertisement;
    }

    public async Task<WhatsAppAdvertisement> GetWhatsAppAdvertisementById(int id)
    {
        var foundAdvertisement = await _advertisementRepository.GetWhatsAppAdvertisementById(id);
        return foundAdvertisement;
    }

    public async Task<IEnumerable<WhatsAppAdvertisement>> GetWhatsAppAdvertisements()
    {
        var foundAdvertisements = await _advertisementRepository.GetWhatsAppAdvertisements();
        return foundAdvertisements;
    }

    public async Task<WhatsAppAdvertisement> UpdateWhatsAppAdvertisementById(int id, WhatsAppAdvertisement advertisement)
    {
        var updatedAdvertisement = await _advertisementRepository.UpdateWhatsAppAdvertisementById(id, advertisement);
        return updatedAdvertisement;
    }
}
