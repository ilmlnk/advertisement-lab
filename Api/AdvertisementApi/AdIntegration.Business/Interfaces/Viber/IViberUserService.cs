using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces.Viber;

public interface IViberUserService
{
    public Task<ViberUser> AddViberUser(ViberUser viberUser);
    public Task<ViberUser> DeleteViberUserById(int id);
    public Task<ViberUser> UpdateViberUserById(int id, ViberUser viberUser);
    public Task<ViberUser> GetViberUserById(int id);
    public Task<IEnumerable<ViberUser>> GetViberUsers();
}
