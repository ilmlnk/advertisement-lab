using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface ISystemUserRepository
{
    public Task<IEnumerable<SystemUser>> GetAllSystemUsers();
    public Task<SystemUser> GetSystemUserById(int id);
    public Task<SystemUser> AddSystemUser(SystemUser user);
    public Task<object> UpdateSystemUser(int userId, SystemUser inputUser);
    public Task<SystemUser> DeleteSystemUser(int id);
    public Task<SystemUser> GetSystemUserByUsername(string username);
    public Task<IEnumerable<SystemUser>> GetOnlineUsers();
}
