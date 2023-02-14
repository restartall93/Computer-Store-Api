using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Computer_Store_Api.Seeder
{
    public class ProductSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public ProductSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                    Image = "/product/imgHomepage/250-21734-laptop-gigabyte-gaming-g5-md-51s1123so.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "Core i5 11400H (2.6 Ghz Up to 4.4 Ghz, 12MB)",
                    RAM = "16GB 3200Mhz, 2 Khe, up to 32GB",
                    Drive = "512GB SSD / có thể Nâng cấp 1 ổ Sata 2.5\"",
                    VGA = "NVIDIA GeForce RTX 3050 4GB GDDR6",
                    Monitor = "15.6 Inch Full HD, 100% srgb",
                    Description = ""

                },
                new Product
                {
                    Id = 2,
                    Name = "Laptop GIGABYTE AORUS 15P YD 73S1224GH (i7-11800H / 16GB/ 1TB SSD/ RTX 3080 8GB / 15.6\"FHD/ Win 10H)",
                    Image = "/product/imgHomepage/250-23571-laptop-gaming-gigabyte-g7-ke-52vn263sh-2.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "Intel Core i5-12500H (2.4GHz~4.5GHz) 12 Cores 16 Threads",
                    RAM = "8GB DDR4 3200MHz",
                    Drive = " 512GB M.2 PCIe",
                    VGA = "RTX 3050 Ti 4GB",
                    Description = "",
                    Monitor = "15.6'' IPS 144Hz FHD"
                },
                new Product
                {
                    Id = 3,
                    Name = "Laptop MSI GF63 11SC-664VN ( I5-11400H/ 8Gb RAM/ 512GB SSD/ 15.6\"FHD/ GTX 1650 4GB/ Win 10/ Black/ 1 Yr)",
                    Image = "/product/imgHomepage/250-21991-si6.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "Intel Core i5-11400H",
                    RAM = "8GB DDR4 3200MHz",
                    Drive = "512GB NVMe M.2 PCIe Gen 3 x 4",
                    VGA = "GTX 1650 Max-Q 4GB",
                    Monitor = "15.6-inch FHD (1920x1080), tấm nền IPS 144hz, close to 100% sRGB, viền mỏng, chống chói",
                    Description = "l",
                },
                new Product
                {
                    Id = 4,
                    Name = "Laptop Dell Gaming G15 5520 71000334 (Core i7-12700H / 16GB RAM/ 512GB SSD/ RTX 3060 6GB/ 15.6 inch FHD 165Hz / Win 11 / Xám/ 1 Yr)",
                    Image = "/product/imgHomepage/250-23933-laptop-dell-gaming-g15-5520-i7h165w11gr3050ti-7.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "Intel Core I3-1115G4",
                    RAM = "8GB",
                    Drive = "256GB SSD",
                    VGA = "Intel UHD Graphics",
                    Monitor = "14 inch FHD 60 Hz",
                    Description = "l"
                },
                new Product
                {
                    Id = 5,
                    Name = "CPU Intel Core i9-11900K (8 Nhân 16 Luồng | 3.50 GHz Turbo 5.3GHz | 16M Cache | 125W)",
                    Image = "/product/imgHomepage/18678-intel-core-i9-11900k.jpg",
                    Category = "Item",
                    ProductType = "CPU",
                    CPU = "Intel Core i9-11900K",
                    RAM = " ",
                    Drive = " ",
                    VGA = " ",
                    Monitor = " ",
                    Description = "l"
                },
                new Product
                {
                    Id = 6,
                    Name = "CPU Intel Core i9-11900KF (8 Nhân 16 Luồng | Turbo 5.3GHz | 16M Cache | 125W)",
                    Image = "/product/imgHomepage/18676-cpunc8.jpg",
                    Category = "Item",
                    ProductType = "CPU",
                    CPU = "Intel Core i9-11900KF",
                    RAM = " ",
                    Drive = " ",
                    VGA = " ",
                    Monitor = " ",
                    Description = "l"
                },
                new Product
                {
                    Id = 7,
                    Name = "Màn hình HKC M24G1 24.0 inch Full HD 144HZ - Cong",
                    Image = "/product/imgHomepage/23423-m--n-h--nh-hkc-m24g1-24-0-inch-full-hd-144hz-4.jpg",
                    Category = "Item",
                    ProductType = "Screen",
                    Monitor = "HKC M24G1 24.0 inch",
                    RAM = " ",
                    Drive = " ",
                    VGA = " ",
                    CPU = " ",
                    Description = "l"
                },
                new Product
                {
                Id = 8,
                    Name = "Card Màn Hình ZOTAC GAMING GeForce GTX 1650 SUPER Twin Fan 4G GDDR6",
                    Image = "/product/imgHomepage/18979-vganc2.jpg",
                    Category = "Item",
                    ProductType = "Card",
                    VGA = "ZOTAC GAMING GeForce GTX 1650 SUPER",
                    Description = "l",
                    RAM = " ",
                    Drive = " ",
                    CPU = " ",
                    Monitor = " ",
                });
        }
    }
}
