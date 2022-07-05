using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bots",
                columns: new[] { "Id", "CreateAt", "Name", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8064), "Jironimo", "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", "JironimoBot" },
                    { 2L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8149), "TelegramBotBlazor", "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", "TelegramBotBlazorBot" }
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
                    { 1L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8350), "testEmail@gmail.com", "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8355), "Alex Yesipov" },
                    { 2L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8380), "testEmail2@gmail.com", "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8384), "Alex Ivanov" },
                    { 3L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8404), "testEmail3@gmail.com", "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8408), "Kate Yesipova" },
                    { 4L, new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8427), "testEmail4@gmail.com", "https://image.pngaaa.com/345/1582345-middle.png", new DateTime(2022, 7, 5, 8, 35, 24, 130, DateTimeKind.Local).AddTicks(8431), "Alex Pupkin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
