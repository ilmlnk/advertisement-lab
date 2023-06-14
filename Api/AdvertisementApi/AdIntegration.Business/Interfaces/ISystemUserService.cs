using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces;

public interface ISystemUserService
{
    public Task<SystemUser> RegisterSystemUser(SystemUser user);
    public Task<SystemUser> GetSystemUserById(int id);
    public Task<SystemUser> GetSystemUserByUsername(string username);
    public Task<SystemUser> DeleteSystemUserById(int id);
    public Task<IEnumerable<SystemUser>> GetSystemUsers();
    public Task<SystemUser> UpdateSystemUserById(int id, SystemUser user);
}
