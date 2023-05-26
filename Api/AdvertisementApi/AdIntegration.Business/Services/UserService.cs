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
    public async Task<SystemUser> GetUserById(int id)
    {
        var user = await _userRepository.GetSystemUserById(id);
        return user;
    }
    public async Task<IEnumerable<SystemUser>> GetAllUsers()
    {
        var users = await _userRepository.GetAllSystemUsers();
        return users;
    }

    public async Task<SystemUser> CreateUser(SystemUser user)
    {
        var createUser = await _userRepository.AddSystemUser(user);
        return createUser;
    }

    public async Task<SystemUser> UpdateUser(int id, SystemUser user)
    {
        var updateUser = await _userRepository.UpdateSystemUser(id, user);
        return (SystemUser) updateUser;
    }

    public async Task<SystemUser> DeleteUserById(int id)
    {
        var deleteUser = await _userRepository.DeleteSystemUser(id);
        return deleteUser;
    }

    public async Task<IEnumerable<SystemUser>> GetOnlineUsers()
    {
        var onlineUsers = await _userRepository.GetOnlineSystemUsers();
        return onlineUsers;
    }
}
