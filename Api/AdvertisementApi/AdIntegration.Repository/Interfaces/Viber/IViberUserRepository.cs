using AdIntegration.Data.Entities.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces.Viber;

public interface IViberUserRepository
{
    public Task<ViberUser> AddViberUser(ViberUser viberUser);
    public Task<ViberUser> UpdateViberUserById(int id, ViberUser viberUser);
    public Task<IEnumerable<ViberUser>> GetViberUsers();
    public Task<ViberUser> GetViberUserById(int id);
    public Task<ViberUser> DeleteViberUserById(int id);
}
