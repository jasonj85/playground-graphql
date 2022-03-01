using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLExample.Migrations
{
    public partial class InitalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Designation", "Name" },
                values: new object[,]
                {
                    { 1, "IT consultant", "Jason" },
                    { 2, "Store Assistant", "Henry" },
                    { 3, "Football Coach", "Susan" },
                    { 4, "School Teacher", "Terri" },
                    { 5, "Navy Officer", "Aaron" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
