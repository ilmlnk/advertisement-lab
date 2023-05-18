using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface IAdvertisementRepository
{
    public Advertisement CreateAdvertisement(Advertisement advertisement);
    public Advertisement DeleteAdvertisement(int id);
    public IEnumerable<Advertisement> GetAllAdvertisements();
    public Advertisement GetAdvertisementById(int id);
    public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement);
}
