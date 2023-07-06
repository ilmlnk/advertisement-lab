using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Data.Entities.WhatsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.WhatsApp;

public class WhatsAppUserService : IWhatsAppUserService
{
    public Task<WhatsAppUser> AddWhatsAppUser(WhatsAppUser user)
    {
        throw new NotImplementedException();
    }

    public Task<WhatsAppUser> DeleteWhatsAppUserById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<WhatsAppUser> GetWhatsAppUserById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WhatsAppUser>> GetWhatsAppUsers()
    {
        throw new NotImplementedException();
    }

    public Task<WhatsAppUser> UpdateWhatsAppUserById(int id, WhatsAppUser user)
    {
        throw new NotImplementedException();
    }
}
