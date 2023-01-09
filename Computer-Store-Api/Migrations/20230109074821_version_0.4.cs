using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    public partial class version_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Computer", "Lap-top" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Computer", "Lap-top" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Computer", "Lap-top" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "ProductType" },
                values: new object[] { "Computer", "Lap-top" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
