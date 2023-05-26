using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class SystemUserRepository : ISystemUserRepository
{
    private readonly ApplicationDbContext _context;

    public SystemUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    /* Create */
    public async Task<SystemUser> AddSystemUser(SystemUser user)
    {
        _context.SystemUsers.Add(user);
        user.UserId = await _context.SaveChangesAsync();
        return user;
    }

    public async Task<IEnumerable<SystemUser>> GetAllSystemUsers()
    {
        var users = await _context.SystemUsers.ToListAsync();
        return users;
    }

    public async Task<SystemUser> GetSystemUserByUsername(string username)
    {
        var user = await _context.SystemUsers.FirstOrDefaultAsync(u => u.UserName == username);
        return user;
    }

    public async Task<SystemUser> GetSystemUserById(int id)
    {
        var user = await _context.SystemUsers.FirstOrDefaultAsync(x => x.UserId == id);
        return user;
    }

    public async Task<IEnumerable<SystemUser>> GetOnlineSystemUsers()
    {
        var onlineUsers = await _context.SystemUsers
            .Where(u => u.IsOnline)
            .ToListAsync();

        return onlineUsers;
    }

    public async Task<object> UpdateSystemUser(int userId, SystemUser inputUser)
    {
        var foundUser = await _context.SystemUsers.FindAsync(userId);

        if (foundUser != null)
        {
            _context.SystemUsers.Update(inputUser);
            await _context.SaveChangesAsync();
        }

        var response = new
        {
            Old = foundUser,
            New = inputUser
        };

        return response;
    }

    public async Task<SystemUser> DeleteSystemUser(int id)
    {
        var deleteUser = await GetSystemUserById(id);

        if (deleteUser != null)
        {
            _context.Users.Remove(deleteUser);
            await _context.SaveChangesAsync();
        }

        return deleteUser;
    }
}
