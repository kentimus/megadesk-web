using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebWeek8.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<int>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    NumDrawers = table.Column<int>(nullable: false),
                    SurfaceMaterial = table.Column<string>(nullable: true),
                    customerName = table.Column<string>(nullable: true),
                    rushDays = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    orderDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
