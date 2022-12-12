using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    public partial class version_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cart_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_details", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.Id);
                })
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

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassWord = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "carts",
                columns: new[] { "Id", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1, 0, 1 },
                    { 2, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CPU", "Description", "Drive", "Image", "Monitor", "Name", "Price", "RAM", "VGA" },
                values: new object[,]
                {
                    { 1, "Intel Core i5 11400H", "l", "512GB SSD", "/product/imgHomepage/250-21734-laptop-gigabyte-gaming-g5-md-51s1123so.jpg", "15.6 inch FHD 144Hz", "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)", 0.0, "16gb", "NVIDIA RTX3050Ti 4G" },
                    { 2, "Core i5 11400H (2.6 Ghz Up to 4.4 Ghz, 12MB)", "l", "512GB SSD / có thể Nâng cấp 1 ổ Sata 2.5'", "/product/imgHomepage/250-21725-laptop-gigabyte-gaming-g5-md-51s1123so.jpg", "15.6 Inch Full HD, 100% srgb", "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6' FHD/RTX3050Ti 4Gb/ Win11)", 0.0, "16GB 3200Mhz, 2 Khe, up to 32GB", "NVIDIA GeForce RTX 3050 4GB GDDR6" },
                    { 3, "AMD Ryzen™ 3-5300U (2.6GHz upto 3.8GHz, 4MB)", "l", "256GB PCIe NVMe", "/product/imgHomepage/250-21615-hp-14s.jpg", "14 inch HD (1366 x 768), micro-edge, BrightView, 250 nits, 45% NTSC", "Laptop HP 14s-fq1080AU 4K0Z7PA (Ryzen 3-5300U/ 4GB / 256GB SSD/ 14' HD/ AMD Radeon/ Win10/ Silver/ 1 Yr)", 0.0, "4GB (1x4GB) DDR4-3200Mhz (2 khe)", "Radeon Vega Graphics" },
                    { 4, "Intel Core I3-1115G4", "l", "256GB SSD", "/product/imgHomepage/250-22706-msi-14.jpg", "14 inch FHD 60 Hz", "Laptop MSI Modern 14 B11MOU-1027VN (I3-1115G4/ 8GB RAM / 256GB SSD/ 14' FHD, 60Hz/ VGA ON/ Win11/ Grey/ 1 Yr)", 0.0, "8GB", "Intel UHD Graphics" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "Name", "PassWord", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "HN", "test1", "test1", "1", "test1" },
                    { 2, "HN", "test2", "test2", "1", "test2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_details");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
