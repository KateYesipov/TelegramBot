using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    public partial class update_chat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastOnline",
                table: "Message");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastOnline",
                table: "Message",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8922), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8933), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8958), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateAt", "LastOnline" },
                values: new object[] { new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 13, 15, 54, 23, 519, DateTimeKind.Local).AddTicks(8972) });
        }
    }
}
