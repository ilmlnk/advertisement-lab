using AdIntegration.Api.Hubs.Clients;
using AdIntegration.Business.Services;
using AdIntegration.Data.Entities;
using Microsoft.AspNetCore.SignalR;

namespace AdIntegration.Api.Hubs;

public class ChatHub : Hub<IChatClient>
{
    public async Task SendMessage(Message message)
    {
        await Clients.All.ReceiveMessage(message);
    }
}
