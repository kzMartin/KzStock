using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KzStock.Migrations
{
    public partial class AddSeedForReportAndFKForPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Employees_EmployeeId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Reports_ReportId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Employees_EmployeeId",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Reports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReportId",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Enabled", "LastName", "Name" },
                values: new object[] { 4, "victor@kzsoftworks.com", true, "Pons", "Victor" });

            migrationBuilder.InsertData(
                table: "Purchase",
                columns: new[] { "Id", "Amount", "EmployeeId", "ProductId", "ReportId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 0 },
                    { 2, 1000, 1, 2, 0 },
                    { 3, 3, 1, 3, 0 },
                    { 7, 1, 2, 2, 0 },
                    { 8, 1000, 2, 1, 0 },
                    { 9, 3, 2, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Date", "EmployeeId", "IsPaid" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 20, 12, 2, 24, 186, DateTimeKind.Local).AddTicks(9905), 1, false },
                    { 3, new DateTime(2018, 7, 27, 12, 2, 24, 187, DateTimeKind.Local).AddTicks(296), 2, true }
                });

            migrationBuilder.InsertData(
                table: "Purchase",
                columns: new[] { "Id", "Amount", "EmployeeId", "ProductId", "ReportId" },
                values: new object[,]
                {
                    { 4, 1, 4, 3, 0 },
                    { 5, 1000, 4, 2, 0 },
                    { 6, 3, 4, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Date", "EmployeeId", "IsPaid" },
                values: new object[] { 2, new DateTime(2019, 4, 23, 12, 2, 24, 187, DateTimeKind.Local).AddTicks(291), 4, false });

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Employees_EmployeeId",
                table: "Purchase",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Reports_ReportId",
                table: "Purchase",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Employees_EmployeeId",
                table: "Reports",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Employees_EmployeeId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Reports_ReportId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Employees_EmployeeId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Reports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReportId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Employees_EmployeeId",
                table: "Purchase",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Reports_ReportId",
                table: "Purchase",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Employees_EmployeeId",
                table: "Reports",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
