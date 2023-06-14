using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Telegram;

public interface ITelegramAdvertisementService
{
    public Task<TelegramAdvertisement> CreateTelegramAdvertisement(TelegramAdvertisement advertisement);
    public Task<TelegramAdvertisement> UpdateTelegramAdvertisementById(int id, TelegramAdvertisement advertisement);
    public Task<TelegramAdvertisement> GetTelegramAdvertisementById(int id);
    public Task<IEnumerable<TelegramAdvertisement>> GetAllTelegramAdvertisements();
    public Task<TelegramAdvertisement> DeleteTelegramAdvertisementById(int id);
}
