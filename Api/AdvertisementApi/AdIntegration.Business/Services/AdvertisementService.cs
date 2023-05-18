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

    /* Create */
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
