using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces;

public interface ISystemUserRepository
{
    public Task<SystemUser> RegisterSystemUser(SystemUser systemUser);
    public Task<SystemUser> UpdateSystemUserById(int id, SystemUser systemUser);
    public Task<IEnumerable<SystemUser>> GetSystemUsers();
    public Task<SystemUser> GetSystemUserById(int id);
    public Task<SystemUser> GetSystemUserByEmail(string email);
}
