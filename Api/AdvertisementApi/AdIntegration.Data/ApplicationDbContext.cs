using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;

namespace AdIntegration.Data
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

        public DbSet<SystemUser> SystemUsers { get; set; }

        /* Users */
        public DbSet<User> Users { get; set; }

        /* Channels */
        public DbSet<Channel> SocialChannels { get; set; }
        public DbSet<TelegramChannel> TelegramChannels { get; set; }
        public DbSet<ViberChannel> ViberChannels { get; set; }
        public DbSet<WhatsAppChannel> WhatsAppChannels { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdminTask> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }

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