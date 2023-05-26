using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface IViberChannelRepository
{
    public Task<ViberChannel> CreateViberChannel(ViberChannel viberChannel);
    public Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel viberChannel);
    public Task<ViberChannel> DeleteViberChannelById(int id);
    public Task<ViberChannel> GetViberChannelById(int id);
    public Task<IEnumerable<ViberChannel>> GetAllViberChannels();
    public Task<IEnumerable<ViberChannel>> GetViberChannelsByCategory(string category);
}
