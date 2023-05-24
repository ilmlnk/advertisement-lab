using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface IWhatsAppChannelRepository
{
    public WhatsAppChannel CreateWhatsAppChannel(WhatsAppChannel whatsAppChannel);
    public WhatsAppChannel UpdateWhatsAppChannelById(int id, WhatsAppChannel whatsAppChannel);
    public WhatsAppChannel UpdateWhatsAppChannelByLink(string link, WhatsAppChannel whatsAppChannel);
    public WhatsAppChannel DeleteWhatsAppChannelById(int id);
    public WhatsAppChannel DeleteWhatsAppChannelByLink(string link);
    public WhatsAppChannel GetWhatsAppChannelById(int id);
    public WhatsAppChannel GetWhatsAppChannelByLink(string link);
    public IEnumerable<WhatsAppChannel> GetAllWhatsAppChannels();
    public IEnumerable<WhatsAppChannel> GetWhatsAppChannelsByCategory(string category);
}
