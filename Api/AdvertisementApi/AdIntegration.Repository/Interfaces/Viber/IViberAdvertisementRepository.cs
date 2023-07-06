using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Viber;

public interface IViberAdvertisementRepository
{
    public Task<ViberAdvertisement> AddViberAdvertisement(ViberAdvertisement viberAdvertisement);
    public Task<ViberAdvertisement> UpdateViberAdvertisementById(int id, ViberAdvertisement viberAdvertisement);
    public Task<ViberAdvertisement> DeleteViberAdvertisementById(int id);
    public Task<ViberAdvertisement> GetViberAdvertisementById(int id);
    public Task<IEnumerable<ViberAdvertisement>> GetViberAdvertisements();
}
