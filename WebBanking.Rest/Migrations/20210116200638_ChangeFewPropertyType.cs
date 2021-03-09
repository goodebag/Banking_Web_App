using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanking.Rest.Migrations
{
    public partial class ChangeFewPropertyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "AccountNumber",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "phonenumber",
                table: "Users",
                nullable: false,
                defaultValue: 0.0);

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
                columns: new[] { "AccountNumber", "Balance", "CreatedAt" },
                values: new object[] { 20005.0, 50000.0, new DateTime(2021, 1, 16, 20, 6, 37, 81, DateTimeKind.Utc).AddTicks(9180) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phonenumber",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "AirtimeTopUps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 395, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "CableRecharges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "CashWithdrawals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 395, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Transfers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 16, 10, 3, 394, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountNumber", "Balance", "CreatedAt" },
                values: new object[] { 20005, 50000, new DateTime(2021, 1, 10, 16, 10, 3, 391, DateTimeKind.Utc).AddTicks(1636) });
        }
    }
}
