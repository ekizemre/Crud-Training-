using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Söförler",
                columns: table => new
                {
                    SöförID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Söförad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Söförler", x => x.SöförID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Söförler");
        }
    }
}
