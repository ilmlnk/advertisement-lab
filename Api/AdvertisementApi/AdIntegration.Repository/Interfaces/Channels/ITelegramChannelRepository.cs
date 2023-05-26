using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface ITelegramChannelRepository
{
    public Task<TelegramChannel> CreateTelegramChannel(TelegramChannel channel);
    public Task<TelegramChannel> UpdateTelegramChannelById(int id,  TelegramChannel channel);
    public Task<TelegramChannel> DeleteTelegramChannelById(int id);
    public Task<TelegramChannel> DeleteTelegramChannelByLink(string link);
    public Task<TelegramChannel> GetTelegramChannelById(int id);
    public Task<TelegramChannel> GetTelegramChannelByLink(string link);
    public Task<IEnumerable<TelegramChannel>> GetAllTelegramChannels();
    public Task<IEnumerable<TelegramChannel>> GetTelegramChannelsByCategory(string category);
}
