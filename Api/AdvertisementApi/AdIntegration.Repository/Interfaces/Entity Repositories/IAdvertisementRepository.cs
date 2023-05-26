using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface IAdvertisementRepository
{
    public Task<Advertisement> CreateAdvertisement(Advertisement advertisement);
    public Task<Advertisement> DeleteAdvertisement(int id);
    public Task<IEnumerable<Advertisement>> GetAllAdvertisements();
    public Task<Advertisement> GetAdvertisementById(int id);
    public Task<Advertisement> UpdateAdvertisementById(int id, Advertisement advertisement);
}
