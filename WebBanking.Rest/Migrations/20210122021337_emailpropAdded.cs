using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanking.Rest.Migrations
{
    public partial class emailpropAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AirtimeTopUps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 971, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "CableRecharges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "CashWithdrawals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 972, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Transfers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 971, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 22, 2, 13, 36, 968, DateTimeKind.Utc).AddTicks(9469));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "AirtimeTopUps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 86, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CableRecharges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 88, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "CashWithdrawals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 87, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 88, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 88, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 88, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 88, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Transfers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 86, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 20, 6, 37, 81, DateTimeKind.Utc).AddTicks(9180));
        }
    }
}
