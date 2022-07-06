using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class update_messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7918), new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7939), new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7956), new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7974), new DateTime(2022, 7, 6, 20, 1, 41, 432, DateTimeKind.Local).AddTicks(7976) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Message");

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(345), new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(370), new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 7, 6, 19, 46, 37, 319, DateTimeKind.Local).AddTicks(384) });
        }
    }
}
