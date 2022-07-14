using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class Update_table_filter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Filters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(335), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(363), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(384), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(404), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(426), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(449), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 7, 14, 11, 46, 21, 543, DateTimeKind.Local).AddTicks(576) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Filters");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(731), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(753), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(775), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(785), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(857) });
        }
    }
}
