using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.DatabaseContext;

public class DbSeeder
{
    private readonly ApplicationDbContext _context;
    public DbSeeder(ApplicationDbContext context)
    {
        _context = context;
    }

    public void SeedData()
    {
        if (!_context.SystemUsers.Any())
        {
            var systemUsers = new List<SystemUser>
            {
                new SystemUser
                {
                    UserId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "johndoe",
                    Password = "password123",
                    Email = "johndoe@example.com",
                    IsOnline = true,
                    Role = "admin"
                },
                new SystemUser
                {
                    UserId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "janesmith",
                    Password = "password456",
                    Email = "janesmith@example.com",
                    IsOnline = false,
                    Role = "user"
                },
                new SystemUser
                {
                    UserId = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    UserName = "michaeljohnson",
                    Password = "password789",
                    Email = "michaeljohnson@example.com",
                    IsOnline = true,
                    Role = "user"
                },
                new SystemUser
                {
                    UserId = 4,
                    FirstName = "Emily",
                    LastName = "Brown",
                    UserName = "emilybrown",
                    Password = "passwordabc",
                    Email = "emilybrown@example.com",
                    IsOnline = false,
                    Role = "user"
                },
                new SystemUser
                {
                    UserId = 5,
                    FirstName = "David",
                    LastName = "Wilson",
                    UserName = "davidwilson",
                    Password = "passwordxyz",
                    Email = "davidwilson@example.com",
                    IsOnline = true,
                    Role = "user"
                }
            };
        }
        if (!_context.Advertisements.Any())
        {
            var advertisements = new List<Advertisement>
            {
                new Advertisement
                {
                    Id = 1,
                    Name = "Ad 1",
                    Topic = "Topic 1",
                    Description = "Description 1",
                    Price = 10.99m,
                    DatePosted = DateTime.Now,
                    UserId = 1,
                },
                new Advertisement
                {
                    Id = 2,
                    Name = "Ad 2",
                    Topic = "Topic 2",
                    Description = "Description 2",
                    Price = 20.99m,
                    DatePosted = DateTime.Now,
                    UserId = 2,
                },
                new Advertisement
                {
                    Id = 3,
                    Name = "Ad 3",
                    Topic = "Topic 3",
                    Description = "Description 3",
                    Price = 30.99m,
                    DatePosted = DateTime.Now,
                    UserId = 3,
                },
                new Advertisement
                {
                    Id = 4,
                    Name = "Ad 4",
                    Topic = "Topic 4",
                    Description = "Description 4",
                    Price = 40.99m,
                    DatePosted = DateTime.Now,
                    UserId = 4,
                },
                new Advertisement
                {
                    Id = 5,
                    Name = "Ad 5",
                    Topic = "Topic 5",
                    Description = "Description 5",
                    Price = 50.99m,
                    DatePosted = DateTime.Now,
                    UserId = 5,
                }
            };

        }
        if (!_context.AdminTasks.Any())
        {

        }
    }
}
