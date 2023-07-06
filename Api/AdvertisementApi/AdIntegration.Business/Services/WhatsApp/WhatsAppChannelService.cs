using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.WhatsApp;

public class WhatsAppChannelService : IWhatsAppChannelService
{
    private readonly IWhatsAppChannelRepository _channelRepository;

    public WhatsAppChannelService(IWhatsAppChannelRepository channelRepository)
    {
        _channelRepository = channelRepository;
    }

    public async Task<WhatsAppChannel> AddWhatsAppChannel(WhatsAppChannel channel)
    {
        var addedChannel = await _channelRepository.AddWhatsAppChannel(channel);
        return addedChannel;
    }

    public async Task<WhatsAppChannel> DeleteWhatsAppChannelById(int id)
    {
        var deletedChannel = await _channelRepository.DeleteWhatsAppChannelById(id);
        return deletedChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelById(int id)
    {
        var foundChannel = await _channelRepository.GetWhatsAppChannelById(id);
        return foundChannel;
    }

    public async Task<WhatsAppChannel> GetWhatsAppChannelByLink(string link)
    {
        var foundChannel = await _channelRepository.GetWhatsAppChannelByLink(link);
        return foundChannel;
    }

    public async Task<IEnumerable<WhatsAppChannel>> GetWhatsAppChannels()
    {
        var foundChannels = await _channelRepository.GetWhatsAppChannels();
        return foundChannels;
    }
}
