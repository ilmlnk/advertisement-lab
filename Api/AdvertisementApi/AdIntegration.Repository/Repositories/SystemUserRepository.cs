using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class SystemUserRepository : ISystemUserRepository
{
    private readonly ApplicationDbContext _context;

    public SystemUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<SystemUser> GetSystemUserByEmail(string email)
    {
        var foundUser = await _context.SystemUsers.FirstOrDefaultAsync(x => x.Email == email);
        return foundUser;
    }

    public async Task<SystemUser> GetSystemUserById(int id)
    {
        var foundUser = await _context.SystemUsers.FindAsync(id);
        return foundUser;
    }

    public async Task<IEnumerable<SystemUser>> GetSystemUsers()
    {
        var foundUsers = await _context.SystemUsers.ToListAsync();
        return foundUsers;
    }

    public async Task<SystemUser> RegisterSystemUser(SystemUser systemUser)
    {
        await _context.SystemUsers.AddAsync(systemUser);
        await _context.SaveChangesAsync();
        return systemUser;
    }

    public async Task<SystemUser> UpdateSystemUserById(int id, SystemUser systemUser)
    {
        var foundUser = await GetSystemUserById(id);

        if (foundUser != null) 
        {
            _context.SystemUsers.Update(systemUser);
            await _context.SaveChangesAsync();
        }

        return foundUser;
    }
}
