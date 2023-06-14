using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Repositories.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Telegram;

public interface ITelegramAdvertisementRepository
{
    public Task<TelegramAdvertisement> CreateTelegramAdvertisement(TelegramAdvertisement advertisement);
    public Task<TelegramAdvertisement> GetTelegramAdvertisementById(int id);
    public Task<TelegramAdvertisement> UpdateTelegramAdvertisementById(int id, TelegramAdvertisement advertisement);
    public Task<IEnumerable<TelegramAdvertisement>> GetTelegramAdvertisements();
    public Task<TelegramAdvertisement> DeleteTelegramAdvertisementById(int id);
}
