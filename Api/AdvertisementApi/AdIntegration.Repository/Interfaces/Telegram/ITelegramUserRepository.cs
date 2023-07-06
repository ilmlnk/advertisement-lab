using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Telegram;

public interface ITelegramUserRepository
{
    public Task<TelegramUser> AddTelegramUser(TelegramUser telegramUser);
    public Task<TelegramUser> UpdateTelegramUserById(int id, TelegramUser telegramUser);
    public Task<TelegramUser> DeleteTelegramUserById(int id);
    public Task<IEnumerable<TelegramUser>> GetTelegramUsers();
    public Task<TelegramUser> GetTelegramUserById(int id);
    public Task<TelegramUser> GetTelegramUserByUsername(string username);
}
