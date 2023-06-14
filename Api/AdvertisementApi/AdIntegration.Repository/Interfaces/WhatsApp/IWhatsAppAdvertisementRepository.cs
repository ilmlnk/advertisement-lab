using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.WhatsApp;

public interface IWhatsAppAdvertisementRepository
{
    public Task<WhatsAppAdvertisement> CreateWhatsAppAdvertisement(WhatsAppAdvertisement whatsAppAdvertisement);
    public Task<WhatsAppAdvertisement> UpdateWhatsAppAdvertisementById(int id, WhatsAppAdvertisement whatsAppAdvertisement);
    public Task<WhatsAppAdvertisement> GetWhatsAppAdvertisementById(int id);
    public Task<IEnumerable<WhatsAppAdvertisement>> GetWhatsAppAdvertisements();
    public Task<WhatsAppAdvertisement> DeleteWhatsAppAdvertisementById(int id);
}
