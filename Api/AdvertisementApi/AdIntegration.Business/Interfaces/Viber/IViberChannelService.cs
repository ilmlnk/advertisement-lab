using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Viber;

public interface IViberChannelService
{
    public Task<ViberChannel> AddViberChannel(ViberChannel viberChannel);
    public Task<ViberChannel> UpdateViberChannelById(int id, ViberChannel viberChannel);
    public Task<IEnumerable<ViberChannel>> GetViberChannels();
    public Task<ViberChannel> GetViberChannelById(int id);
    public Task<ViberChannel> DeleteViberChannelById(int id);
}
