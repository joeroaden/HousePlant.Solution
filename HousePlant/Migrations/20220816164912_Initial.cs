using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HousePlant.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CommonName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Sunlight = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Water = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Humidity = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Soil = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Propagation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TempMin = table.Column<int>(type: "int", nullable: false),
                    TempMax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
