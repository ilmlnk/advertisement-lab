using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.WhatsApp;

public interface IWhatsAppChannelService
{
    public Task<WhatsAppChannel> AddWhatsAppChannel(WhatsAppChannel channel);
    public Task<WhatsAppChannel> DeleteWhatsAppChannelById(int id);
    public Task<WhatsAppChannel> GetWhatsAppChannelById(int id);
    public Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannels();
    public Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link);
}
