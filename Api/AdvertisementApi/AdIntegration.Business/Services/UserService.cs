using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;

namespace AdIntegration.Business.Services;

public class UserService : IUserService
{
    private readonly SystemUserRepository _userRepository;
    public UserService(SystemUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public SystemUser GetUserById(int id)
    {
        var user = _userRepository.GetUserById(id);
        return (SystemUser) user;
    }
    public IEnumerable<SystemUser> GetAllUsers()
    {
        var users = _userRepository.GetAllUsers();
        return (IEnumerable<SystemUser>) users;
    }

    public SystemUser CreateUser(SystemUser user)
    {
        var createUser = _userRepository.AddUser(user);
        return (SystemUser) createUser;
    }

    public SystemUser UpdateUser(int id, SystemUser user)
    {
        var updateUser = _userRepository.UpdateUser(id, user);
        return (SystemUser) updateUser;
    }

    public SystemUser DeleteUserById(int id)
    {
        var deleteUser = _userRepository.DeleteUser(id);
        return (SystemUser) deleteUser;
    }

    public IEnumerable<SystemUser> GetOnlineUsers()
    {
        var onlineUsers = _userRepository.GetOnlineUsers();
        return onlineUsers;
    }
}
