using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bots",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastOnline = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TelegramChatId = table.Column<long>(type: "bigint", nullable: false),
                    PartnerAvatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BotUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BotAvatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BotId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_Bots_BotId",
                        column: x => x.BotId,
                        principalTable: "Bots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPartner = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageGroupId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bots",
                columns: new[] { "Id", "CreateAt", "Name", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(3586), "Jironimo", "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", "JironimoBot" },
                    { 2L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(3656), "TelegramBotBlazor", "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", "TelegramBotBlazorBot" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorHex" },
                values: new object[,]
                {
                    { 1L, "#FFFFFF" },
                    { 2L, "#3C95FF" },
                    { 3L, "#FFCE31" },
                    { 4L, "#25CC62" },
                    { 5L, "#ED4C5C" },
                    { 6L, "#9C4CED" },
                    { 7L, "#4CEDED" },
                    { 8L, "#ED4CB6" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "CreateAt", "Email", "ImgPath", "LastOnline", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5251), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5433), "Alex Yesipov" },
                    { 2L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5504), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5512), "Alex Ivanov" },
                    { 3L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5535), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5538), "Kate Yesipova" },
                    { 4L, new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5551), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 6, 12, 39, 25, 181, DateTimeKind.Local).AddTicks(5553), "Alex Pupkin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_CategoryId",
                table: "Answers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_BotId",
                table: "Chat",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Id",
                table: "Chat",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Bots");
        }
    }
}
