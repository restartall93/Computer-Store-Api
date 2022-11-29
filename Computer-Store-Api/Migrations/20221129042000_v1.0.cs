using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPU = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RAM = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Drive = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VGA = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Monitor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CPU", "Description", "Drive", "Image", "Monitor", "Name", "Price", "RAM", "VGA" },
                values: new object[] { 1, "Intel Core i5 11400H", "l", "512GB SSD", "/product/test.jpg", "NVIDIA RTX3050Ti 4G", "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)", 0.0, "16gb", "NVIDIA RTX3050Ti 4G" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CPU", "Description", "Drive", "Image", "Monitor", "Name", "Price", "RAM", "VGA" },
                values: new object[] { 2, "Intel Core i5 11400H", "l", "512GB SSD", "/product/test.jpg", "NVIDIA RTX3050Ti 4G", "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)", 0.0, "16gb", "NVIDIA RTX3050Ti 4G" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CPU", "Description", "Drive", "Image", "Monitor", "Name", "Price", "RAM", "VGA" },
                values: new object[] { 3, "Intel Core i5 11400H", "l", "512GB SSD", "/product/test.jpg", "NVIDIA RTX3050Ti 4G", "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)", 0.0, "16gb", "NVIDIA RTX3050Ti 4G" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
