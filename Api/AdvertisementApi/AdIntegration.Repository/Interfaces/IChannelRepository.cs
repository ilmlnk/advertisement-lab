using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;

namespace AdIntegration.Repository.Interfaces;

public interface IChannelRepository
{
    /* Create */
    public Channel CreateChannel(Channel channel);
    /* Update */
    public object UpdateChannelById(int id, Channel channel);
    /* Get */
    public Channel GetChannelById(int id);
    public Channel GetChannelByName(string name);
    public Channel GetChannelByLink(string channelType, string link);
    public IEnumerable<Channel> GetChannelsByCategory(string category);
    public Channel GetChannelByEmail(string email);
    public IEnumerable<Channel> GetChannels();
    public IEnumerable<TelegramChannel> GetTelegramChannels();
    public IEnumerable<ViberChannel> GetVibersChannels();
    public IEnumerable<WhatsAppChannel> GetWhatsAppChannels();
    /* Delete */
    public Channel DeleteChannelById(int id);

}
