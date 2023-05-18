using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdIntegration.Data.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext() { }

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    _configuration.GetConnectionString("AdvertisementDb"),
                    x => x.MigrationsAssembly("AdIntegration.Api")
                )
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }

        /*
         * - Users (in general)
         * - SystemUsers
         * - TelegramUsers
         * - ViberUsers
         * - WhatsAppUsers
         * 
         * - Channels (in general)
         * - TelegramChannels
         * - WhatsAppChannels
         * - ViberChannels
         * 
         * - ActionLogs
         * - AdminTasks
         * - Advertisements
         * - Posts
         * - Comments
         * - Tags
         * 
         */

        public DbSet<User> Users { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<TelegramUser> TelegramUsers { get; set; }
        public DbSet<ViberUser> ViberUsers { get; set; }
        public DbSet<WhatsAppUser> WhatsAppUsers { get; set; }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<TelegramChannel> TelegramChannels { get; set; }
        public DbSet<WhatsAppChannel> WhatsAppChannels { get; set; }
        public DbSet<ViberChannel> ViberChannels { get; set; }

        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<AdminTask> AdminTasks { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity
                .HasKey(e => e.UserId);

                entity.HasIndex(u => u.UserName).IsUnique();

            });

            modelBuilder.Entity<AdminTask>(entity =>
            {
                entity
                .HasKey(t => t.Id);

                entity
                .HasMany(t => t.Tags)
                .WithOne(at => at.Task)
                .HasForeignKey(ti => ti.TaskId);
            });

            modelBuilder.Entity<TelegramChannel>(entity =>
            {
                entity.HasIndex(i => i.InviteLink).IsUnique();
            });

            modelBuilder.Entity<WhatsAppChannel>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<ViberChannel>(entity =>
            {
                /*entity
                .Property(c => c.Location)
                .HasConversion(
                    p => JsonConvert.SerializeObject(p),
                    s => JsonConvert.DeserializeObject<Point>(s));
                */
                entity
                .Property(e => e.EventTypes)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    );
            }
        );


            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity
                .HasOne(a => a.UserEntity)
                .WithMany()
                .HasForeignKey(e => e.Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}