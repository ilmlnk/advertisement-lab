using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Viber;

public interface IViberAdvertisementService
{
    public Task<ViberAdvertisement> CreateViberAdvertisement(ViberAdvertisement advertisement);
    public Task<ViberAdvertisement> DeleteViberAdvertisementById(int id);
    public Task<ViberAdvertisement> GetViberAdvertisementById(int id);
    public Task<IEnumerable<ViberAdvertisement>> GetViberAdvertisements();
    public Task<ViberAdvertisement> UpdateViberAdvertisementById(int id, ViberAdvertisement advertisement);
}
