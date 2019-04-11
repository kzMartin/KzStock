using Microsoft.EntityFrameworkCore.Migrations;

namespace KzStock.Migrations
{
    public partial class UpdateProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                "ID",
                "Products",
                "Id");

            migrationBuilder.AddColumn<int>(
                "Stock",
                "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                "UnitPrice",
                "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                "Products",
                new[] {"Id", "Name", "Stock", "UnitPrice"},
                new object[,]
                {
                    {1, "Galletas Oreo", 10, 50.0},
                    {2, "Coca Cola", 8, 35.0},
                    {3, "Agua Helada", 15, 45.0},
                    {4, "Jugo Ades", 3, 22.0},
                    {5, "Helado Palito", 5, 12.0}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "Products",
                "Id",
                1);

            migrationBuilder.DeleteData(
                "Products",
                "Id",
                2);

            migrationBuilder.DeleteData(
                "Products",
                "Id",
                3);

            migrationBuilder.DeleteData(
                "Products",
                "Id",
                4);

            migrationBuilder.DeleteData(
                "Products",
                "Id",
                5);

            migrationBuilder.DropColumn(
                "Stock",
                "Products");

            migrationBuilder.DropColumn(
                "UnitPrice",
                "Products");

            migrationBuilder.RenameColumn(
                "Id",
                "Products",
                "ID");
        }
    }
}