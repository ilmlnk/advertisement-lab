using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface IUserService
    {
        public Task<SystemUser> CreateUser(SystemUser user);
        public Task<SystemUser> UpdateUser(int id, SystemUser user);
        public Task<SystemUser> DeleteUserById(int id);
        public Task<IEnumerable<SystemUser>> GetAllUsers();
        public Task<SystemUser> GetUserById(int id);
        public Task<IEnumerable<SystemUser>> GetOnlineUsers();
    }
}
