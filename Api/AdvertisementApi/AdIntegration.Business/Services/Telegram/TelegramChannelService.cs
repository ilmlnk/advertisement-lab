using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Telegram;

public class TelegramChannelService : ITelegramChannelService
{
    private readonly ITelegramChannelRepository _channelRepository;

    public TelegramChannelService(ITelegramChannelRepository channelRepository)
    {
        _channelRepository = channelRepository;
    }

    public async Task<TelegramChannel> AddTelegramChannel(TelegramChannel telegramChannel)
    {
        var addedChannel = await _channelRepository.AddTelegramChannel(telegramChannel);
        return addedChannel;
    }

    public async Task<TelegramChannel> DeleteTelegramChannelById(int id)
    {
        var deletedChannel = await _channelRepository.DeleteTelegramChannelById(id);
        return deletedChannel;
    }

    public async Task<TelegramChannel> GetTelegramChannelById(int id)
    {
        var foundChannel = await _channelRepository.GetTelegramChannelById(id);
        return foundChannel;
    }

    public async Task<TelegramChannel> GetTelegramChannelByLink(string link)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TelegramChannel>> GetTelegramChannels()
    {
        var foundChannels = await _channelRepository.GetTelegramChannels();
        return foundChannels;
    }

    public async Task<TelegramChannel> UpdateTelegramChannelById(int id, TelegramChannel telegramChannel)
    {
        var updatedChannel = await _channelRepository.UpdateTelegramChannelById(id, telegramChannel);
        return updatedChannel;
    }
}
