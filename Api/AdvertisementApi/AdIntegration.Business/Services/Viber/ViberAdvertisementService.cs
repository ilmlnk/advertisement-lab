using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Viber;
using AdIntegration.Repository.Repositories.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Viber;

public class ViberAdvertisementService : IViberAdvertisementService
{
    private readonly IViberAdvertisementRepository _advertisementRepository;

    public ViberAdvertisementService(IViberAdvertisementRepository advertisementRepository)
    {
        _advertisementRepository = advertisementRepository;
    }

    public async Task<ViberAdvertisement> CreateViberAdvertisement(ViberAdvertisement advertisement)
    {
        var createdAdvertisement = await _advertisementRepository.AddViberAdvertisement(advertisement);
        return createdAdvertisement;
    }

    public async Task<ViberAdvertisement> DeleteViberAdvertisementById(int id)
    {
        var deletedAdvertisement = await _advertisementRepository.DeleteViberAdvertisementById(id);
        return deletedAdvertisement;
    }

    public async Task<ViberAdvertisement> GetViberAdvertisementById(int id)
    {
        var foundAdvertisement = await _advertisementRepository.GetViberAdvertisementById(id);
        return foundAdvertisement;
    }

    public async Task<IEnumerable<ViberAdvertisement>> GetViberAdvertisements()
    {
        var foundAdvertisements = await _advertisementRepository.GetViberAdvertisements();
        return foundAdvertisements;
    }

    public async Task<ViberAdvertisement> UpdateViberAdvertisementById(int id, ViberAdvertisement advertisement)
    {
        var updatedAdvertisement = await _advertisementRepository.UpdateViberAdvertisementById(id, advertisement);
        return updatedAdvertisement;
    }
}
