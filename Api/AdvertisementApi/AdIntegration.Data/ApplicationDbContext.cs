using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetTopologySuite.IO;

namespace AdIntegration.Data
{
    public class ApplicationDbContext<T, V> : DbContext where T : User where V : Channel<T>
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
        public DbSet<User> Users { get; set; }
        public DbSet<Channel<T>> Channels { get; set; }
        public DbSet<Advertisement<T, V>> Advertisements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity
                .HasKey(e => e.UserId)
                .HasName("PrimaryKey_UserId");

                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(u => u.UserName).IsUnique();
            });

            modelBuilder.Entity<TelegramUser>(entity =>
            {

            });

            modelBuilder.Entity<Advertisement<T, V>>(entity =>
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