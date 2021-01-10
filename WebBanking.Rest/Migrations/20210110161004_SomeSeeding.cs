using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanking.Rest.Migrations
{
    public partial class SomeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CreatedAt", "GetTransactionType", "TransactionId", "UpdatedAt", "UserId", "theTransactionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(6423), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 2, new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(6905), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 3, new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(7019), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 4, new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(7105), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "FullName", "IdentityId", "Pin", "TransactionId", "UpdatedAt", "photopath" },
                values: new object[] { 1, 20005, 50000, new DateTime(2021, 1, 10, 16, 10, 3, 391, DateTimeKind.Utc).AddTicks(1636), "chima", new Guid("00000000-0000-0000-0000-000000000000"), 2020, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "image2.jpg" });

            migrationBuilder.InsertData(
                table: "AirtimeTopUps",
                columns: new[] { "Id", "Amount", "CreatedAt", "PhoneNo", "SenderId", "UpdatedAt", "networkType" },
                values: new object[] { 1, 500, new DateTime(2021, 1, 10, 16, 10, 3, 395, DateTimeKind.Utc).AddTicks(1339), 9094096185.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "CableRecharges",
                columns: new[] { "Id", "Amount", "CableNo", "CableType", "CreatedAt", "SenderId", "UpdatedAt" },
                values: new object[] { 1, 2900, 9012345, 1, new DateTime(2021, 1, 10, 16, 10, 3, 396, DateTimeKind.Utc).AddTicks(1534), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CashWithdrawals",
                columns: new[] { "Id", "Amount", "CreatedAt", "UpdatedAt", "WithdrawerId" },
                values: new object[] { 1, 1000, new DateTime(2021, 1, 10, 16, 10, 3, 395, DateTimeKind.Utc).AddTicks(5702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Transfers",
                columns: new[] { "Id", "Amount", "CreatedAt", "ReciverAccountNo", "SenderId", "UpdatedAt", "WhichBank" },
                values: new object[] { 1, 2000, new DateTime(2021, 1, 10, 16, 10, 3, 394, DateTimeKind.Utc).AddTicks(5595), 20006, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AirtimeTopUps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CableRecharges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CashWithdrawals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transfers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
