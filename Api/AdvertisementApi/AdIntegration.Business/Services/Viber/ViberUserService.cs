using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Viber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Viber;

public class ViberUserService : IViberUserService
{
    private readonly IViberUserRepository _userRepository;

    public ViberUserService(IViberUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ViberUser> AddViberUser(ViberUser viberUser)
    {
        var addedUser = await _userRepository.AddViberUser(viberUser);
        return addedUser;
    }

    public async Task<ViberUser> DeleteViberUserById(int id)
    {
        var deletedUser = await _userRepository.DeleteViberUserById(id);
        return deletedUser;
    }

    public async Task<ViberUser> GetViberUserById(int id)
    {
        var foundUser = await _userRepository.GetViberUserById(id);
        return foundUser;
    }

    public async Task<IEnumerable<ViberUser>> GetViberUsers()
    {
        var foundUsers = await _userRepository.GetViberUsers();
        return foundUsers;
    }

    public async Task<ViberUser> UpdateViberUserById(int id, ViberUser viberUser)
    {
        var updatedUser = await _userRepository.UpdateViberUserById(id, viberUser);
        return updatedUser;
    }
}
