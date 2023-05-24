using AdIntegration.Business.Interfaces.Channels;
using AdIntegration.Repository.Repositories.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Channels;

public class TelegramChannelService : ITelegramChannelService
{
    private readonly TelegramChannelRepository _channelRepository;
    public TelegramChannelService(TelegramChannelRepository channelRepository) 
    {
        _channelRepository = channelRepository;
    }

    

}
