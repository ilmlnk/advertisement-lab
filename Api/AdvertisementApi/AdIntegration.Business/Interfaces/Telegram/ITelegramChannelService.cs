using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Telegram;

public interface ITelegramChannelService
{
    public Task<TelegramChannel> AddTelegramChannel(TelegramChannel telegramChannel);
    public Task<TelegramChannel> DeleteTelegramChannelById(int id);
    public Task<TelegramChannel> GetTelegramChannelById(int id);
    public Task<IEnumerable<TelegramChannel>> GetTelegramChannels();
    public Task<TelegramChannel> UpdateTelegramChannelById(int id, TelegramChannel telegramChannel);
    public Task<TelegramChannel> GetTelegramChannelByLink(string link);
}
