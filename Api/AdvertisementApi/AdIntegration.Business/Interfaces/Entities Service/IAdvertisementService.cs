using AdIntegration.Data.Entities;


namespace AdIntegration.Business.Interfaces;

public interface IAdvertisementService
{
    public Task<Advertisement> CreateAdvertisement(Advertisement advertisement);
    public Task<Advertisement> UpdateAdvertisementById(int id, Advertisement advertisement);
    public Task<Advertisement> DeleteAdvertisement(int id);
    public Task<IEnumerable<Advertisement>> GetAllAdvertisements();
    public Task<Advertisement> GetAdvertisementById(int id);
}
