using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Viber;

public interface IViberChannelRepository
{
    public Task<ViberChannel> AddViberChannel(ViberChannel channel);
    public Task<IEnumerable<ViberChannel>> AddViberChannels(List<ViberChannel> viberChannels);
    public Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel channel);
    public Task<ViberChannel> GetViberChannelById(int id);
    public Task<IEnumerable<ViberChannel>> GetViberChannels();
    public Task<ViberChannel> DeleteViberChannelById(int id);
    public Task<ViberChannel> GetViberChannelByEmail(string email);
}
