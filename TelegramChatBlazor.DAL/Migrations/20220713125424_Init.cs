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
                name: "Filters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Readed = table.Column<bool>(type: "bit", nullable: false),
                    Archived = table.Column<bool>(type: "bit", nullable: false),
                    Mailing = table.Column<bool>(type: "bit", nullable: false),
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
                    BotId = table.Column<long>(type: "bigint", nullable: false),
                    languageCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    MessageGroupId = table.Column<long>(type: "bigint", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    LastOnline = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        name: "FK_Attachments_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bots",
                columns: new[] { "Id", "CreateAt", "Name", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8735), "Jironimo", "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", "JironimoBot" },
                    { 2L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8799), "TelegramBotBlazor", "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", "TelegramBotBlazorBot" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9107), "Hello-bye" },
                    { 2L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9121), "Продажа" },
                    { 3L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9130), "Брокеры" },
                    { 4L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9140), "Hello-bye" },
                    { 5L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9150), "Продажа" },
                    { 6L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9160), "Брокеры" },
                    { 7L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9170), "Hello-bye" },
                    { 8L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9179), "Продажа" },
                    { 9L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9189), "Брокеры" }
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
                    { 17L, "Japanese", "ja" },
                    { 18L, "Lithuanian", "lt" },
                    { 19L, "Latvian", "lv" },
                    { 20L, "Dutch", "nl" },
                    { 21L, "Polish", "pl" },
                    { 22L, "Portuguese", "pt" },
                    { 23L, "PortugueseBrazilian", "pt-BR" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "languageCode" },
                values: new object[,]
                {
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
                    { 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8883), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8886), "Alex Yesipov" },
                    { 2L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8898), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8901), "Alex Ivanov" },
                    { 3L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8910), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8912), "Kate Yesipova" },
                    { 4L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8922), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8924), "Alex Pupkin" },
                    { 5L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8933), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8936), "Alex Yesipov" },
                    { 6L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8946), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8948), "Alex Ivanov" },
                    { 7L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8958), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8960), "Kate Yesipova" },
                    { 8L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8970), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8972), "Alex Pupkin" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "FullAnswer", "ShortName" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9205), "Hello-bye", "Hi" },
                    { 2L, 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9218), "Hello how are you?", "Hi how" },
                    { 3L, 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9228), "Hey!How do you do? I'm ready to talk to you and answer your questions. ", "Чем могу помочь ?" },
                    { 4L, 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9238), "How do I get a demo version?https://globalforexforum.com/threads/elon-musk-ea-demo.340/", "Подпишись на канал с результатами" },
                    { 5L, 1L, new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9247), "Okay, thanks for the request ! If you have any new questions about ELM_EA, please let me know. I am online and ready to help you 24/5", "Спасибо за ваш запрос" }
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
                name: "Message");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Bots");
        }
    }
}
