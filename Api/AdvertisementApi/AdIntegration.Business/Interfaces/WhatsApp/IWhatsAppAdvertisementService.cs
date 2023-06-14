using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.WhatsApp;

public interface IWhatsAppAdvertisementService
{
    public Task<WhatsAppAdvertisement> AddWhatsAppAdvertisement(WhatsAppAdvertisement advertisement);
    public Task<WhatsAppAdvertisement> DeleteWhatsAppAdvertisementById(int id);
    public Task<WhatsAppAdvertisement> UpdateWhatsAppAdvertisementById(int id, WhatsAppAdvertisement advertisement);
    public Task<WhatsAppAdvertisement> GetWhatsAppAdvertisementById(int id);
    public Task<IEnumerable<WhatsAppAdvertisement>> GetWhatsAppAdvertisements();
}
