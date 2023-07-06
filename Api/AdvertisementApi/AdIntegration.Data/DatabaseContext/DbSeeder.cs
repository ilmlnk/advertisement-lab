using AdIntegration.Data.Entities.Abstractions;
using AdIntegration.Data.Entities.Telegram;
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
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "johndoe",
                    Password = "password123",
                    Email = "johndoe@example.com",
                },
                new SystemUser
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "janesmith",
                    Password = "password456",
                    Email = "janesmith@example.com",
                },
                new SystemUser
                {
                    FirstName = "Michael",
                    LastName = "Johnson",
                    UserName = "michaeljohnson",
                    Password = "password789",
                    Email = "michaeljohnson@example.com",
                },
                new SystemUser
                {
                    FirstName = "Emily",
                    LastName = "Brown",
                    UserName = "emilybrown",
                    Password = "passwordabc",
                    Email = "emilybrown@example.com",
                },
                new SystemUser
                {
                    FirstName = "David",
                    LastName = "Wilson",
                    UserName = "davidwilson",
                    Password = "passwordxyz",
                    Email = "davidwilson@example.com",
                }
            };
            _context.SystemUsers.AddRange(systemUsers);
            _context.SaveChanges();
        }
        if (!_context.TelegramAdvertisements.Any())
        {
            var advertisements = new List<TelegramAdvertisement>
            {
                new TelegramAdvertisement
                {
                    Name = "Ad 1",
                    Topic = "Topic 1",
                    Description = "Description 1",
                    Price = 10.99m,
                    SystemUserId = 1,
                },
                new TelegramAdvertisement
                {
                    Name = "Ad 2",
                    Topic = "Topic 2",
                    Description = "Description 2",
                    Price = 20.99m,
                    SystemUserId = 2,
                },
                new TelegramAdvertisement
                {
                    Name = "Ad 3",
                    Topic = "Topic 3",
                    Description = "Description 3",
                    Price = 30.99m,
                    SystemUserId = 3,
                },
                new TelegramAdvertisement
                {
                    Name = "Ad 4",
                    Topic = "Topic 4",
                    Description = "Description 4",
                    Price = 40.99m,
                    SystemUserId = 4,
                },
                new TelegramAdvertisement
                {
                    Name = "Ad 5",
                    Topic = "Topic 5",
                    Description = "Description 5",
                    Price = 50.99m,
                    SystemUserId = 5,
                }
            };
            _context.TelegramAdvertisements.AddRange(advertisements);
            _context.SaveChanges();
        }
        /*if (!_context.AdminTasks.Any())
        {
            var adminTasks = new List<AdminTask>
            {
                new AdminTask
                {
                    Id = 1,
                    Name = "Task 1",
                    Topic = "Topic 1",
                    Description = "Description 1",
                    Status = "Done",
                    Priority = 1,
                    CreatedAtDate = DateTime.Now,
                    DueToDate = DateTime.Now.AddDays(7),
                    AssignedToUserId = 1,
                    TagIds = new List<int> { 1, 2 },
                    CommentIds = new List<int> { 1, 2 }
                },
                new AdminTask
                {
                    Id = 2,
                    Name = "Task 2",
                    Topic = "Topic 2",
                    Description = "Description 2",
                    Status = "Done",
                    Priority = 2,
                    CreatedAtDate = DateTime.Now,
                    DueToDate = DateTime.Now.AddDays(7),
                    AssignedToUserId = 2,
                    TagIds = new List<int> { 1, 2 },
                    CommentIds = new List<int> { 1, 2 }
                },
                new AdminTask
                {
                    Id = 3,
                    Name = "Task 3",
                    Topic = "Topic 3",
                    Description = "Description 3",
                    Status = "In process",
                    Priority = 1,
                    CreatedAtDate = DateTime.Now,
                    DueToDate = DateTime.Now.AddDays(7),
                    AssignedToUserId = 3,
                    TagIds = new List<int> { 1, 2 },
                    CommentIds = new List<int> { 1, 2 }
                },
                new AdminTask
                {
                    Id = 4,
                    Name = "Task 4",
                    Topic = "Topic 4",
                    Description = "Description 4",
                    Status = "To do",
                    Priority = 0,
                    CreatedAtDate = DateTime.Now,
                    DueToDate = DateTime.Now.AddDays(7),
                    AssignedToUserId = 4,
                    TagIds = new List<int> { 1, 2 },
                    CommentIds = new List<int> { 1, 2 }
                },
                new AdminTask
                {
                    Id = 5,
                    Name = "Task 5",
                    Topic = "Topic 5",
                    Description = "Description 5",
                    Status = "Done",
                    Priority = 1,
                    CreatedAtDate = DateTime.Now,
                    DueToDate = DateTime.Now.AddDays(7),
                    AssignedToUserId = 1,
                    TagIds = new List<int> { 1, 2 },
                    CommentIds = new List<int> { 1, 2 }
                },
            };
            _context.AdminTasks.AddRange(adminTasks);
            _context.SaveChanges();
        }*/
        if (!_context.TelegramChannels.Any())
        {
            var telegramChannels = new List<TelegramChannel> {
            new TelegramChannel
            {
                Name = "Channel 1",
                Description = "Description 1",
                IsPrivate = false,
                ActiveUsersCount = 100,
                Posts = 50,
                ChannelUrl = "https://t.me/channel1",
                IsSuperGroup = false,
                IsBroadcast = true,
                InviteLink = "https://t.me/joinchat/invite1",
            },
            new TelegramChannel
            {
                Name = "Channel 2",
                Description = "Description 2",
                IsPrivate = true,
                ActiveUsersCount = 200,
                Posts = 100,
                ChannelUrl = "https://t.me/channel2",
                IsSuperGroup = true,
                IsBroadcast = false,
                InviteLink = "https://t.me/joinchat/invite2",
            },
            new TelegramChannel
                {
                    Name = "Channel 3",
                    Description = "Description 3",
                    IsPrivate = false,
                    ActiveUsersCount = 150,
                    Posts = 75,
                    ChannelUrl = "https://t.me/channel3",
                    IsSuperGroup = false,
                    IsBroadcast = true,
                    InviteLink = "https://t.me/joinchat/invite3",
                },
                new TelegramChannel
                {
                    Name = "Channel 4",
                    Description = "Description 4",
                    IsPrivate = true,
                    ActiveUsersCount = 250,
                    Posts = 120,
                    ChannelUrl = "https://t.me/channel4",
                    IsSuperGroup = true,
                    IsBroadcast = false,
                    InviteLink = "https://t.me/joinchat/invite4",
                },
                new TelegramChannel
                {
                    Name = "Channel 5",
                    Description = "Description 5",
                    IsPrivate = false,
                    ActiveUsersCount = 180,
                    Posts = 90,
                    ChannelUrl = "https://t.me/channel5",
                    IsSuperGroup = true,
                    IsBroadcast = true,
                    InviteLink = "https://t.me/joinchat/invite5",
                },
            };
            _context.TelegramChannels.AddRange(telegramChannels);
            _context.SaveChanges();
        }
    }
}
