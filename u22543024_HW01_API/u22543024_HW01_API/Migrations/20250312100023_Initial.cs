using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u22543024_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "High-performance running shoes designed with breathable mesh and a cushioned sole for maximum comfort and support. Features a sleek design and durable rubber outsole for traction on various surfaces.", "Running Shoes", 89.989999999999995 },
                    { 2, "Sleek leather boots with elastic side panels for easy wear. Features a comfortable insole and durable rubber outsole, ideal for everyday wear.", "Boots", 89.0 },
                    { 3, "A classic baseball cap with an adjustable strap and embroidered logo. Made of breatable cotton, perfect for casual and outdoor activities.", "Baseball Cap", 19.989999999999998 },
                    { 4, "Flowing, floor-length mix dress made from lightweight fabric. Features an adjustable strap design and a flattering A-line sihouette.", "Maxi Dress", 59.990000000000002 },
                    { 5, "A pair of slim-fit chinos made from lightweight cotton with a bit of stretch. Features a clean, modern look suitable for both work and weekend wear.", "Slim Fit Chinos", 44.950000000000003 },
                    { 6, "Cozy hoodie with a bold graphic print on the front. Made of soft cotton, perfect for lounging or casual outings.", "Hoodie", 49.990000000000002 },
                    { 7, "Comfortable and stylish jogger sweatpants with an elastic waistband and cuffs. Features side pockets and a soft fleece interior for extra warmth.", "Jogger Sweatpants", 39.990000000000002 },
                    { 8, "A fleece jacket is a lightweight, warm, and breathable outwear piece made from synthetic material like polyster. It provides excellent insulation by trapping heat while remaing soft and comfortable. Fleece jackets are popular for outdoor activities, layering in cold casual wear due to thier moisture-wicking properties and ease of care.", "Fleece Jacket", 70.0 },
                    { 9, "Jeans are durable pants made from from demin fabric, designed as workwear but suitable for casual and fashion wear. Feature a button or ziper fly, belt loops, and pockets. They come in various shades, from classic blue to black, white, and distressed finishes. ", "Jeans", 600.0 },
                    { 10, "A T-Shirt is a casual, short-sleeved garment made from soft fabric, typically cotton. Designed with a round or V-shaped neckline, in various colours, patterns, and styles, including fitted, oversized, and grphic-printed designs.", "T-Shirt", 67.989999999999995 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
