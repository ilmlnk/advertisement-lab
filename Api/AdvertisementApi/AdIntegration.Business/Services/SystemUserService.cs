using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services;

public class SystemUserService : ISystemUserService
{
    public Task<SystemUser> DeleteSystemUserById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SystemUser> GetSystemUserById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SystemUser> GetSystemUserByUsername(string username)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SystemUser>> GetSystemUsers()
    {
        throw new NotImplementedException();
    }

    public Task<SystemUser> RegisterSystemUser(SystemUser user)
    {
        throw new NotImplementedException();
    }

    public Task<SystemUser> UpdateSystemUserById(int id, SystemUser user)
    {
        throw new NotImplementedException();
    }
}
