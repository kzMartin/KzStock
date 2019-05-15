using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KzStock.Migrations
{
    public partial class AddEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Enabled", "LastName", "Name" },
                values: new object[] { 1, "martin@kzsoftworks.com", true, "Mato", "Martin" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Enabled", "LastName", "Name" },
                values: new object[] { 2, "james@kzsoftworks.com", true, "Bond", "James" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Enabled", "LastName", "Name" },
                values: new object[] { 3, "fulano@kzsoftworks.com", true, "Detal", "Fulano" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
