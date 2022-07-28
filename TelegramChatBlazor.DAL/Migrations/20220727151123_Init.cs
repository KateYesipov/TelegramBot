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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Filters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Readed = table.Column<bool>(type: "bit", nullable: true),
                    Archived = table.Column<bool>(type: "bit", nullable: true),
                    Mailing = table.Column<bool>(type: "bit", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    languageCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
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
                name: "UserStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorAvatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    languageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserStatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserStatus_UserStatusId",
                        column: x => x.UserStatusId,
                        principalTable: "UserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TelegramChatId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BotId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Bots_BotId",
                        column: x => x.BotId,
                        principalTable: "Bots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPartner = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageGroupId = table.Column<long>(type: "bigint", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bots",
                columns: new[] { "Id", "CreateAt", "ImagePath", "Name", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2023), "https://flowxo.com/wp-content/uploads/2021/03/Telegram-Logo-512x512.png", "Jironimo", "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", "JironimoBot" },
                    { 2L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2109), "https://way23.ru/images/botfather-300x300.jpg", "TelegramBotBlazor", "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", "TelegramBotBlazorBot" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2723), "Hello-bye" },
                    { 2L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2743), "Продажа" },
                    { 3L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2758), "Брокеры" },
                    { 4L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2774), "Hello-bye" },
                    { 5L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2789), "Продажа" },
                    { 6L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2859), "Брокеры" },
                    { 7L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2876), "Hello-bye" },
                    { 8L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2891), "Продажа" },
                    { 9L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2906), "Брокеры" }
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
                table: "Filters",
                columns: new[] { "Id", "Archived", "ColorHex", "Created_at", "Mailing", "Name", "Readed" },
                values: new object[,]
                {
                    { 1L, false, "#FFCE31", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3441), false, "Demo", true },
                    { 2L, false, "#ED4C5C", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3466), false, "Will buy soon", true },
                    { 3L, false, "#4CEDED", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3485), false, "Client", true },
                    { 4L, false, "#FFFFFF", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3502), true, "Test", true },
                    { 5L, false, "#25CC62", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3519), false, "Readed", true },
                    { 6L, true, "#ED4CB6", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3602), false, "1 Step", true }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "languageCode" },
                values: new object[,]
                {
                    { 1L, "Bulgarian", "bg" },
                    { 2L, "Czech", "cs" },
                    { 3L, "Bulgarian", "bg" },
                    { 4L, "Danish", "da" },
                    { 5L, "German", "el" },
                    { 6L, "Greek", "cs" },
                    { 7L, "English", "en" },
                    { 8L, "EnglishBritish", "en-GB" },
                    { 9L, "EnglishAmerican", "en-US" },
                    { 10L, "Spanish", "es" },
                    { 11L, "Estonian", "et" },
                    { 12L, "Finnish", "fi" },
                    { 13L, "French", "fr" },
                    { 14L, "Hungarian", "hu" },
                    { 15L, "Indonesian", "id" },
                    { 16L, "Italian", "it" },
                    { 17L, "Japanese", "ja" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "languageCode" },
                values: new object[,]
                {
                    { 18L, "Lithuanian", "lt" },
                    { 19L, "Latvian", "lv" },
                    { 20L, "Dutch", "nl" },
                    { 21L, "Polish", "pl" },
                    { 22L, "Portuguese", "pt" },
                    { 23L, "PortugueseBrazilian", "pt-BR" },
                    { 24L, "Romanian", "ro" },
                    { 25L, "Russian", "ru" },
                    { 26L, "Slovak", "sk" },
                    { 27L, "Slovenian", "sl" },
                    { 28L, "Swedish", "sv" },
                    { 29L, "Turkish", "tr" },
                    { 30L, "Chinese", "zh" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "CreateAt", "Email", "ImgPath", "LastOnline", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2557), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2561), "Alex Yesipov" },
                    { 2L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2581), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2585), "Alex Ivanov" },
                    { 3L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2602), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2605), "Kate Yesipova" },
                    { 4L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2621), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2624), "Alex Pupkin" },
                    { 5L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2640), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2643), "Alex Yesipov" },
                    { 6L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2662), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2665), "Alex Ivanov" },
                    { 7L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2680), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2684), "Kate Yesipova" },
                    { 8L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2699), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2703), "Alex Pupkin" }
                });

            migrationBuilder.InsertData(
                table: "UserStatus",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2245), "Start Chat" },
                    { 2L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2281), "Questions" },
                    { 3L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2299), "Will buy soon" },
                    { 4L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2315), "Client" },
                    { 5L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2331), "Client Pro" },
                    { 6L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2350), "Demo" },
                    { 7L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2530), "Waiting for a discount" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "FullAnswer", "ShortName" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2932), "Hello-bye", "Hi" },
                    { 2L, 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2954), "Hello how are you?", "Hi how" },
                    { 3L, 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2971), "Hey!How do you do? I'm ready to talk to you and answer your questions. ", "Чем могу помочь ?" },
                    { 4L, 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(2987), "How do I get a demo version?https://globalforexforum.com/threads/elon-musk-ea-demo.340/", "Подпишись на канал с результатами" },
                    { 5L, 1L, new DateTime(2022, 7, 27, 18, 11, 22, 889, DateTimeKind.Local).AddTicks(3004), "Okay, thanks for the request ! If you have any new questions about ELM_EA, please let me know. I am online and ready to help you 24/5", "Спасибо за ваш запрос" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_CategoryId",
                table: "Answers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_MessageId",
                table: "Attachments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_BotId",
                table: "Chats",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_Id",
                table: "Chats",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserStatusId",
                table: "Users",
                column: "UserStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Bots");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserStatus");
        }
    }
}
