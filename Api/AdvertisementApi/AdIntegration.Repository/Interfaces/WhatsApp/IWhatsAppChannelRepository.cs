using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.WhatsApp;

public interface IWhatsAppChannelRepository
{
    public Task<WhatsAppChannel> AddWhatsAppChannel(WhatsAppChannel channel);
    public Task<IEnumerable<WhatsAppChannel>> AddWhatsAppChannels(List<WhatsAppChannel> channels);
    public Task<WhatsAppChannel> DeleteWhatsAppChannelById(int id);
    public Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannels();
    public Task<WhatsAppChannel> GetWhatsAppChannelById(int id);
    public Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link);
    public Task<WhatsAppChannel> GetWhatsAppChannelByEmail(string email);

}
