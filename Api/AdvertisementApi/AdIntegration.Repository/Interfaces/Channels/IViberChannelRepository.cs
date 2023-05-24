using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Channels;

public interface IViberChannelRepository
{
    public ViberChannel CreateViberChannel(ViberChannel viberChannel);
    public ViberChannel UpdateViberChannelById(int id, ViberChannel viberChannel);
    public ViberChannel DeleteViberChannelById(int id);
    public ViberChannel GetViberChannelById(int id);
    public IEnumerable<ViberChannel> GetAllViberChannels();
    public IEnumerable<ViberChannel> GetViberChannelsByCategory(string category);
}
