using AdIntegration.Data.Entities.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface ITelegramChannelRepository
{
    public TelegramChannel CreateTelegramChannel(TelegramChannel channel);
    public TelegramChannel UpdateTelegramChannelById(int id,  TelegramChannel channel);
    public TelegramChannel DeleteTelegramChannelById(int id);
    public TelegramChannel DeleteTelegramChannelByLink(string link);
    public TelegramChannel GetTelegramChannelById(int id);
    public TelegramChannel GetTelegramChannelByLink(string link);
    public IEnumerable<TelegramChannel> GetAllTelegramChannels();
    public IEnumerable<TelegramChannel> GetTelegramChannelsByCategory(string category);
}
