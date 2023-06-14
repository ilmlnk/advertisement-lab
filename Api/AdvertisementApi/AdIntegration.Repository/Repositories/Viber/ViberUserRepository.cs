using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Repository.Interfaces.Viber;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Viber;

public class ViberUserRepository : IViberUserRepository
{
    private readonly ApplicationDbContext _context;

    public ViberUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ViberUser> AddViberUser(ViberUser viberUser)
    {
        await _context.ViberUsers.AddAsync(viberUser);
        await _context.SaveChangesAsync();
        return viberUser;
    }

    public async Task<ViberUser> DeleteViberUserById(int id)
    {
        var foundUser = await GetViberUserById(id);

        if (foundUser != null) {
            _context.ViberUsers.Remove(foundUser);
            await _context.SaveChangesAsync();
        }

        return foundUser;
    }

    public async Task<ViberUser> GetViberUserById(int id)
    {
        var foundUser = await _context.ViberUsers.FindAsync(id);
        return foundUser;
    }

    public async Task<IEnumerable<ViberUser>> GetViberUsers()
    {
        var foundUsers = await _context.ViberUsers.ToListAsync();
        return foundUsers;
    }

    public async Task<ViberUser> UpdateViberUserById(int id, ViberUser viberUser)
    {
        var foundUser = await GetViberUserById(id);

        if (foundUser != null)
        {
            _context.ViberUsers.Remove(foundUser);
            await _context.SaveChangesAsync();
        }

        return foundUser;
    }
}
