using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanking.Rest.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CreatedAt", "GetTransactionType", "TransactionId", "UpdatedAt", "UserId", "theTransactionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 22, 11, 4, 55, 931, DateTimeKind.Utc).AddTicks(1566), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 2, new DateTime(2021, 1, 22, 11, 4, 55, 931, DateTimeKind.Utc).AddTicks(1892), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 3, new DateTime(2021, 1, 22, 11, 4, 55, 931, DateTimeKind.Utc).AddTicks(1949), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 },
                    { 4, new DateTime(2021, 1, 22, 11, 4, 55, 931, DateTimeKind.Utc).AddTicks(1989), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20005, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "Email", "FullName", "IdentityId", "Pin", "TransactionId", "UpdatedAt", "phonenumber", "photopath" },
                values: new object[] { 1, 20005.0, 50000.0, new DateTime(2021, 1, 22, 11, 4, 55, 926, DateTimeKind.Utc).AddTicks(7888), null, "chima", new Guid("00000000-0000-0000-0000-000000000000"), 2020, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "image2.jpg" });

            migrationBuilder.InsertData(
                table: "AirtimeTopUps",
                columns: new[] { "Id", "Amount", "CreatedAt", "PhoneNo", "SenderId", "UpdatedAt", "networkType" },
                values: new object[] { 1, 500, new DateTime(2021, 1, 22, 11, 4, 55, 930, DateTimeKind.Utc).AddTicks(114), 9094096185.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "CableRecharges",
                columns: new[] { "Id", "Amount", "CableNo", "CableType", "CreatedAt", "SenderId", "UpdatedAt" },
                values: new object[] { 1, 2900, 9012345, 1, new DateTime(2021, 1, 22, 11, 4, 55, 930, DateTimeKind.Utc).AddTicks(7832), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CashWithdrawals",
                columns: new[] { "Id", "Amount", "CreatedAt", "UpdatedAt", "WithdrawerId" },
                values: new object[] { 1, 1000, new DateTime(2021, 1, 22, 11, 4, 55, 930, DateTimeKind.Utc).AddTicks(3437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Transfers",
                columns: new[] { "Id", "Amount", "CreatedAt", "ReciverAccountNo", "SenderId", "UpdatedAt", "WhichBank" },
                values: new object[] { 1, 2000, new DateTime(2021, 1, 22, 11, 4, 55, 929, DateTimeKind.Utc).AddTicks(3594), 20006, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });
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
