using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface IWhatsAppChannelRepository
{
    public Task<WhatsAppChannel> CreateWhatsAppChannel(WhatsAppChannel whatsAppChannel);
    public Task<WhatsAppChannel> UpdateWhatsAppChannelById(int id, WhatsAppChannel whatsAppChannel);
    public Task<WhatsAppChannel> UpdateWhatsAppChannelByLink(string link, WhatsAppChannel whatsAppChannel);
    public Task<WhatsAppChannel> DeleteWhatsAppChannelById(int id);
    public Task<WhatsAppChannel> DeleteWhatsAppChannelByLink(string link);
    public Task<WhatsAppChannel> GetWhatsAppChannelById(int id);
    public Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link);
    public Task<IEnumerable<WhatsAppChannel>> GetAllWhatsAppChannels();
    public Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannelsByCategory(string category);
}
