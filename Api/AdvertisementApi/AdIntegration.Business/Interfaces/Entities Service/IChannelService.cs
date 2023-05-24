using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;

namespace AdIntegration.Business.Interfaces;

public interface IChannelService
{
    /* Create Channel */
    public TelegramChannel CreateTelegramChannel(TelegramChannel telegramChannel);
    public ViberChannel CreateViberChannel(ViberChannel viberChannel);
    public WhatsAppChannel CreateWhatsAppChannel(WhatsAppChannel whatsAppChannel);

    public object UpdateTelegramChannel(TelegramChannel telegramChannel);
    public object UpdateViberChannel(ViberChannel viberChannel);
    public object UpdateWhatsAppChannel(WhatsAppChannel wktAppChannel);
    public object UpdateChannelById(int id, Channel channel);

    public Channel GetChannelById(int channelId);

    public IEnumerable<Channel> GetAllChannels();
    public IEnumerable<TelegramChannel> GetAllTelegramChannels();
    public IEnumerable<ViberChannel> GetAllViberChannels();
    public IEnumerable<WhatsAppChannel> GetAllWhatsAppChannels();

    public Channel DeleteChannelById(int channelId);
    public TelegramChannel DeleteTelegramChannelById(int channelId);
    public ViberChannel DeleteViberChannelById(int channelId);
    public WhatsAppChannel DeleteWhatsAppChannelById(int channelId);
}
