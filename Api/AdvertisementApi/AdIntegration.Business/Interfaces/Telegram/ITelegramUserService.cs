using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Telegram;

public interface ITelegramUserService
{
    public Task<TelegramUser> AddTelegramUser(TelegramUser telegramUser);
    public Task<TelegramUser> DeleteTelegramUserById(int id);
    public Task<TelegramUser> UpdateTelegramUserById(int id, TelegramUser telegramUser);
    public Task<TelegramUser> GetTelegramUserById(int id);
    public Task<IEnumerable<TelegramUser>> GetTelegramUsers();
    public Task<TelegramUser> GetTelegramUserByUsername(string username);
}
