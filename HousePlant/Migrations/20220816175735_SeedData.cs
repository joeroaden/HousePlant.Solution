using Microsoft.EntityFrameworkCore.Migrations;

namespace HousePlant.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "CommonName", "Description", "Humidity", "Name", "Propagation", "Soil", "Sunlight", "TempMax", "TempMin", "Type", "Water" },
                values: new object[] { 1, "AGAVE", "An agave plant comes in all different sizes and shapes; some are extremely  large and belong growing outside while the smaller varieties make perfect indoor potted houseplants. Agave plants are succulents with multi-layered rosettes of thick, fleshy, leaves. The short, thick stem is often hidden by the large, leathery leaves. If there are children and pets in the house, avoid purchasing agave plants that have sharp, pointed leaves with spiny margins. The sap in the agave leaves is very irritating and the spines and sharp points are painful if they puncture your skin. It takes many, many years for an agave plant to flower, especially when grown indoors. Some varieties may eventually produce a very tall stalk with clusters of flowers at the top. You may not want your agave plant to bloom since, strangely, they often die after flowering.", "drought resistance", "AGAVE PLANT", "Offset", "succulent potting soil", "bright light", 80, 65, "Earth", "every 2-3 weeks" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "CommonName", "Description", "Humidity", "Name", "Propagation", "Soil", "Sunlight", "TempMax", "TempMin", "Type", "Water" },
                values: new object[] { 2, "African Violet Plant", "An African Violet plant  is a small, compact, short plant with soft, furry, thick, round or oval shaped leaves. The leaves grow close together, in a tight group, on long stems, at the base of the plant. An African Violet plant produces beautiful, delicate flowers with five, velvety petals. The flowers can be white, yellow, blue, violet, pink, or fuchsia. Some of the newer varieties have large double, and bi-colored flowers.", "high humidity", "Saintpaulia Ionantha", "leaf cuttings", "rich, airy, potting mixture", "bright indirect light", 80, 65, "Flowering", "Once 1-2 inches of soil is dry" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "CommonName", "Description", "Humidity", "Name", "Propagation", "Soil", "Sunlight", "TempMax", "TempMin", "Type", "Water" },
                values: new object[] { 3, "African Mask plant", "An Alocasia plant, native to Asia and eastern Australia, is also called an Elephant Ear plant or African Mask plant because of its very large, glossy, heart-shaped leaves, some with very, wavy edges. The leaves may be as large as eight to thirty five inches (20cm-90cm) in length. This plant does produce flowers, but the flowers are small and insignificant and certainly pale in comparison to the beautiful plant leaves. In its native habitat, an alocasia plant grows on the floor of the forest which explains why it likes bright light, but direct sun burns the beautiful leaves.", "high humidity", "Alocasia", "plant division", "well-aerated, fast draining, loose soil", "very bright indirect light", 80, 60, "small flowers with bold leaf patterns", "Once top 2-3 inches of soil is dry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3);
        }
    }
}
