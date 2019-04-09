using Microsoft.EntityFrameworkCore.Migrations;

namespace KzStock.Migrations
{
    public partial class PopulateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name) VALUES" + 
                                                " ('Oreo')," +
                                                " ('Hogareñas')," +
                                                " ('Cerealitas')," +
                                                " ('Alfajor Agua Helada')," +
                                                " ('Alfajor Nativo')," +
                                                " ('Coca Cola')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products Where ID < 7");
        }
    }
}
