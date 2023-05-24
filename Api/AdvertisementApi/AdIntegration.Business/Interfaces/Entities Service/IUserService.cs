using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface IUserService
    {
        public SystemUser CreateUser(SystemUser user);
        public SystemUser UpdateUser(int id, SystemUser user);
        public SystemUser DeleteUserById(int id);
        public IEnumerable<SystemUser> GetAllUsers();
        public SystemUser GetUserById(int id);
        public IEnumerable<SystemUser> GetOnlineUsers();
    }
}
