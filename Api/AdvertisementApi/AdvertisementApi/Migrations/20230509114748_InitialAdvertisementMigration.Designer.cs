﻿// <auto-generated />
using System;
using AdIntegration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdIntegration.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230509114748_InitialAdvertisementMigration")]
    partial class InitialAdvertisementMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdIntegration.Data.Entities.AdminTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignedToUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToUserId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ChannelTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChannelTypeId");

                    b.ToTable("Advertisement");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActiveUsers")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<long>("Likes")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Posts")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SocialChannels");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminTaskId")
                        .HasColumnType("int");

                    b.Property<int?>("ChannelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminTaskId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskTag");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("ChannelId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Telegram.TelegramChannel", b =>
                {
                    b.HasBaseType("AdIntegration.Data.Entities.Channel");

                    b.Property<string>("ChannelUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InviteLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsBroadcast")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuperGroup")
                        .HasColumnType("bit");

                    b.HasIndex("InviteLink")
                        .IsUnique()
                        .HasFilter("[InviteLink] IS NOT NULL");

                    b.ToTable("TelegramChannel");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Viber.ViberChannel", b =>
                {
                    b.HasBaseType("AdIntegration.Data.Entities.Channel");

                    b.Property<string>("AuthToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Background")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EventTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Subcategory")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ViberChannel");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.WhatsApp.WhatsAppChannel", b =>
                {
                    b.HasBaseType("AdIntegration.Data.Entities.Channel");

                    b.Property<int>("BusinessProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subcategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("WhatsAppChannel");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.SystemUser", b =>
                {
                    b.HasBaseType("AdIntegration.Data.Entities.User");

                    b.ToTable("SystemUser");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.AdminTask", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedTo");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Advertisement", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.Channel", "ChannelType")
                        .WithMany()
                        .HasForeignKey("ChannelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdIntegration.Data.Entities.SystemUser", "UserEntity")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ChannelType");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Comment", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.AdminTask", null)
                        .WithMany("Comments")
                        .HasForeignKey("AdminTaskId");

                    b.HasOne("AdIntegration.Data.Entities.Channel", null)
                        .WithMany("Comments")
                        .HasForeignKey("ChannelId");

                    b.HasOne("AdIntegration.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Tag", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.AdminTask", "Task")
                        .WithMany("Tags")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.User", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.Channel", null)
                        .WithMany("UserAdmins")
                        .HasForeignKey("ChannelId");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Telegram.TelegramChannel", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.Channel", null)
                        .WithOne()
                        .HasForeignKey("AdIntegration.Data.Entities.Telegram.TelegramChannel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Viber.ViberChannel", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.Channel", null)
                        .WithOne()
                        .HasForeignKey("AdIntegration.Data.Entities.Viber.ViberChannel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.WhatsApp.WhatsAppChannel", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.Channel", null)
                        .WithOne()
                        .HasForeignKey("AdIntegration.Data.Entities.WhatsApp.WhatsAppChannel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.SystemUser", b =>
                {
                    b.HasOne("AdIntegration.Data.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("AdIntegration.Data.Entities.SystemUser", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.AdminTask", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("AdIntegration.Data.Entities.Channel", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("UserAdmins");
                });
#pragma warning restore 612, 618
        }
    }
}
