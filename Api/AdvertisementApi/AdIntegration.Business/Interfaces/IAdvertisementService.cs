using AdIntegration.Data.Entities;


namespace AdIntegration.Business.Interfaces;

public interface IAdvertisementService
{
    public Advertisement CreateAdvertisement(Advertisement advertisement);
    public Advertisement UpdateAdvertisementById(int id, Advertisement advertisement);
    public Advertisement DeleteAdvertisement(int id);
    public IEnumerable<Advertisement> GetAllAdvertisements();
    public Advertisement GetAdvertisementById(int id);
}
