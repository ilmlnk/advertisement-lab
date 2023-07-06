using AdIntegration.Data.Entities.Abstractions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class PasswordHasherService
    {
        private readonly IPasswordHasher<User> _passwordHasher;

        public PasswordHasherService(IPasswordHasher<User> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public string HashPassword(User user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }

        public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
        {
            return _passwordHasher.VerifyHashedPassword(user, hashedPassword, providedPassword);
        }
    }
}
