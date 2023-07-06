using AdIntegration.Data.Entities;

namespace AdIntegration.Api.Hubs.Clients;

public interface IChatClient
{
    public Task ReceiveMessage(Message message);
}
