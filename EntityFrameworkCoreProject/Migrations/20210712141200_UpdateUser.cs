using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreProject.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1, 23, "Tom" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 2, 26, "Alice" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 3, 28, "Sam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
