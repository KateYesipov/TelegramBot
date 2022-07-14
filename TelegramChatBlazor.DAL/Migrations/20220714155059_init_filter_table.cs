using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class init_filter_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Readed",
                table: "Filters",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Mailing",
                table: "Filters",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Archived",
                table: "Filters",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "Archived", "ColorHex", "Created_at", "Mailing", "Name", "Readed" },
                values: new object[,]
                {
                    { 1L, false, "#FFCE31", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6011), false, "Demo", true },
                    { 2L, false, "#ED4C5C", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6026), false, "Will buy soon", true },
                    { 3L, false, "#4CEDED", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6036), false, "Client", true },
                    { 4L, false, "#FFFFFF", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6047), true, "Test", true },
                    { 5L, false, "#25CC62", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6057), false, "Readed", true },
                    { 6L, true, "#ED4CB6", new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(6068), false, "1 Step", true }
                });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5237), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5401), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5413), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5426), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5449), new DateTime(2022, 7, 14, 18, 50, 58, 632, DateTimeKind.Local).AddTicks(5451) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Filters",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.AlterColumn<bool>(
                name: "Readed",
                table: "Filters",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Mailing",
                table: "Filters",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Archived",
                table: "Filters",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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
    }
}
