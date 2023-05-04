using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdIntegration.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialAdIntegrationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialChannels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ActiveUsers = table.Column<int>(type: "int", nullable: false),
                    Posts = table.Column<int>(type: "int", nullable: true),
                    ChannelType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialChannels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelegramChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ChannelUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuperGroup = table.Column<bool>(type: "bit", nullable: false),
                    IsBroadcast = table.Column<bool>(type: "bit", nullable: false),
                    InviteLink = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramChannel_SocialChannels_Id",
                        column: x => x.Id,
                        principalTable: "SocialChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_SocialChannels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "SocialChannels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ViberChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AuthToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subcategory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViberChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViberChannel_SocialChannels_Id",
                        column: x => x.Id,
                        principalTable: "SocialChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WhatsAppChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BusinessProfileId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UrlAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatsAppChannel_SocialChannels_Id",
                        column: x => x.Id,
                        principalTable: "SocialChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUser", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_SystemUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SocialMediaUserUserId = table.Column<int>(type: "int", nullable: false),
                    ChannelEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisement_SocialChannels_ChannelEntityId",
                        column: x => x.ChannelEntityId,
                        principalTable: "SocialChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisement_SystemUser_Id",
                        column: x => x.Id,
                        principalTable: "SystemUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisement_Users_SocialMediaUserUserId",
                        column: x => x.SocialMediaUserUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_ChannelEntityId",
                table: "Advertisement",
                column: "ChannelEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_SocialMediaUserUserId",
                table: "Advertisement",
                column: "SocialMediaUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramChannel_InviteLink",
                table: "TelegramChannel",
                column: "InviteLink",
                unique: true,
                filter: "[InviteLink] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ChannelId",
                table: "Users",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WhatsAppChannel_Email",
                table: "WhatsAppChannel",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "TelegramChannel");

            migrationBuilder.DropTable(
                name: "ViberChannel");

            migrationBuilder.DropTable(
                name: "WhatsAppChannel");

            migrationBuilder.DropTable(
                name: "SystemUser");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SocialChannels");
        }
    }
}
