using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Business.Services;

public class AdvertisementService : IAdvertisementService
{
    private readonly IAdvertisementRepository _advertisementRepository;

    public AdvertisementService(IAdvertisementRepository advertisementRepository)
    {
        _advertisementRepository = advertisementRepository;
    }

    public async Task<Advertisement> CreateAdvertisement(Advertisement advertisement)
    {
        var createdAdvertisement = await _advertisementRepository.CreateAdvertisement(advertisement);
        return createdAdvertisement;
    }

    public async Task<Advertisement> DeleteAdvertisement(int id)
    {
        var deletedAdvertisement = await _advertisementRepository.DeleteAdvertisement(id);
        return deletedAdvertisement;
    }

    public async Task<Advertisement> GetAdvertisementById(int id)
    {
        var adverisement = await _advertisementRepository.GetAdvertisementById(id);
        return adverisement;
    }

    public async Task<IEnumerable<Advertisement>> GetAllAdvertisements()
    {
        var advertisements = await _advertisementRepository.GetAllAdvertisements();
        return advertisements;
    }

    public async Task<Advertisement> UpdateAdvertisementById(int id, Advertisement advertisement)
    {
        var updatedAdvertisement = await _advertisementRepository.UpdateAdvertisementById(id, advertisement);
        return advertisement;
    }
}
