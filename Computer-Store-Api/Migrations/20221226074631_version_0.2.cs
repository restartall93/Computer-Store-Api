using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    public partial class version_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Lap-top", "Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Lap-top", "Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Lap-top", "Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Lap-top", "Computer" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CPU", "Category", "Description", "Drive", "Image", "Monitor", "Name", "Price", "ProductType", "RAM", "VGA" },
                values: new object[,]
                {
                    { 5, "Intel Core i9-11900K", "Item", "l", " ", "/product/imgHomepage/18678-intel-core-i9-11900k.jpg", " ", "CPU Intel Core i9-11900K (8 Nhân 16 Luồng | 3.50 GHz Turbo 5.3GHz | 16M Cache | 125W)", 0.0, "CPU", " ", " " },
                    { 6, "Intel Core i9-11900KF", "Item", "l", " ", "/product/imgHomepage/18676-cpunc8.jpg", " ", "CPU Intel Core i9-11900KF (8 Nhân 16 Luồng | Turbo 5.3GHz | 16M Cache | 125W)", 0.0, "CPU", " ", " " },
                    { 7, " ", "Item", "l", " ", "/product/imgHomepage/23423-m--n-h--nh-hkc-m24g1-24-0-inch-full-hd-144hz-4.jpg", "HKC M24G1 24.0 inch", "Màn hình HKC M24G1 24.0 inch Full HD 144HZ - Cong", 0.0, "Screen", " ", " " },
                    { 8, " ", "Item", "l", " ", "/product/imgHomepage/18979-vganc2.jpg", " ", "Card Màn Hình ZOTAC GAMING GeForce GTX 1650 SUPER Twin Fan 4G GDDR6", 0.0, "Card", " ", "ZOTAC GAMING GeForce GTX 1650 SUPER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "products");
        }
    }
}
