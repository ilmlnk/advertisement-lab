using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Viber;

public class ViberChannelService : IViberChannelService
{
    private readonly IViberChannelRepository _channelRepository;

    public ViberChannelService(IViberChannelRepository channelRepository)
    {
        _channelRepository = channelRepository;
    }

    public async Task<ViberChannel> AddViberChannel(ViberChannel viberChannel)
    {
        var addedChannel = await _channelRepository.AddViberChannel(viberChannel);
        return addedChannel;
    }

    public async Task<ViberChannel> DeleteViberChannelById(int id)
    {
        var deletedChannel = await _channelRepository.DeleteViberChannelById(id);
        return deletedChannel;
    }

    public async Task<ViberChannel> GetViberChannelById(int id)
    {
        var foundChannel = await _channelRepository.GetViberChannelById(id);
        return foundChannel;
    }

    public async Task<IEnumerable<ViberChannel>> GetViberChannels()
    {
        var foundChannels = await _channelRepository.GetViberChannels();
        return foundChannels;
    }

    public async Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel viberChannel)
    {
        var updatedChannel = await _channelRepository.UpdateViberChannelById(id, viberChannel);
        return updatedChannel;
    }
}
