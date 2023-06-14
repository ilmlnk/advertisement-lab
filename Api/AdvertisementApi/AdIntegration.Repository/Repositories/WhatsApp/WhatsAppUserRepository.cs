using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces.WhatsApp;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories.WhatsApp;

public class WhatsAppUserRepository : IWhatsAppUserRepository
{
    private readonly ApplicationDbContext _context;

    public WhatsAppUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<WhatsAppUser> AddWhatsAppUser(WhatsAppUser user)
    {
        await _context.WhatsAppUsers.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<WhatsAppUser> DeleteWhatsAppUserById(int id)
    {
        var foundUser = await GetWhatsAppUserById(id);

        if (foundUser != null)
        {
            _context.WhatsAppUsers.Remove(foundUser);
            await _context.SaveChangesAsync();
        }

        return foundUser;
    }

    public async Task<WhatsAppUser> GetWhatsAppUserById(int id)
    {
        var foundUser = await _context.WhatsAppUsers.FindAsync(id);
        return foundUser;
    }

    public async Task<IEnumerable<WhatsAppUser>> GetWhatsAppUsers()
    {
        var foundUsers = await _context.WhatsAppUsers.ToListAsync();
        return foundUsers;
    }

    public async Task<WhatsAppUser> UpdateWhatsAppUserById(int id, WhatsAppUser user)
    {
        var foundUser = await GetWhatsAppUserById(id);
        
        if (foundUser != null)
        {
            _context.WhatsAppUsers.Update(user);
            await _context.SaveChangesAsync();
        }

        return foundUser;
    }
}
