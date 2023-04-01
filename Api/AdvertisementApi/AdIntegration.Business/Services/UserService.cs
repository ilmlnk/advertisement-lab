using AdIntegration.Business.Models;
using AdIntegration.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _dbContext;

        public async Task<User> Authenticate(string username, string password)
        {
            /*User user = await _dbContext.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                throw new Exception("User not found");
            }*/
            return null;
        }
    }
}
