using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Abstractions;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetTopologySuite.IO;

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

        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<TelegramAdvertisement> TelegramAdvertisements { get; set; }
        public DbSet<TelegramChannel> TelegramChannels { get; set; }
        public DbSet<TelegramUser> TelegramUsers { get; set; }

        public DbSet<ViberAdvertisement> ViberAdvertisements { get; set; }
        public DbSet<ViberChannel> ViberChannels { get; set; }
        public DbSet<ViberUser> ViberUsers { get; set; }

        public DbSet<WhatsAppAdvertisement> WhatsAppAdvertisements { get; set; }
        public DbSet<WhatsAppChannel> WhatsAppChannels { get; set; }
        public DbSet<WhatsAppUser> WhatsAppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Advertisement>(entity =>
            {
                entity
                .HasOne(a => a.SystemUserEntity)
                .WithMany()
                .HasForeignKey(e => e.AdvertisementId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

                entity
                .Property(a => a.DatePosted)
                .HasDefaultValueSql("GETDATE()");


            });*/

            /*modelBuilder.Entity<Channel>(entity =>
            {
                entity
                .HasKey(e => e.ChannelId)
                .HasName("PrimaryKey_ChannelId");
            });*/

            /*modelBuilder.Entity<User>(entity =>
            {
                entity
                .HasKey(e => e.UserId)
                .HasName("PrimaryKey_UserId");
            });*/

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(u => u.UserName).IsUnique();
            });


            modelBuilder.Entity<TelegramUser>(entity =>
            {

            });

            modelBuilder.Entity<TelegramChannel>(entity =>
            {
                entity.HasKey(c => c.ChannelId);

            });

            modelBuilder.Entity<TelegramAdvertisement>(entity =>
            {

            });

            modelBuilder.Entity<ViberUser>(entity =>
            {

            });

            modelBuilder.Entity<ViberChannel>(entity =>
            {
            });

            modelBuilder.Entity<ViberAdvertisement>(entity =>
            {

            });

            modelBuilder.Entity<WhatsAppUser>(entity =>
            {

            });

            modelBuilder.Entity<WhatsAppChannel>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<WhatsAppAdvertisement>(entity =>
            {

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}