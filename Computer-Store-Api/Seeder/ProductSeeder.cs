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
                    CPU = "Intel Core i5 11400H",
                    RAM = "16gb",
                    Drive = "512GB SSD",
                    VGA = "NVIDIA RTX3050Ti 4G",
                    Monitor = "15.6 inch FHD 144Hz",
                    Description = "l"

                },
                new Product
                {
                    Id = 2,
                    Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6' FHD/RTX3050Ti 4Gb/ Win11)",
                    Image = "/product/imgHomepage/250-21725-laptop-gigabyte-gaming-g5-md-51s1123so.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "Core i5 11400H (2.6 Ghz Up to 4.4 Ghz, 12MB)",
                    RAM = "16GB 3200Mhz, 2 Khe, up to 32GB",
                    Drive = "512GB SSD / có thể Nâng cấp 1 ổ Sata 2.5'",
                    VGA = "NVIDIA GeForce RTX 3050 4GB GDDR6",
                    Description = "l",
                    Monitor = "15.6 Inch Full HD, 100% srgb"
                },
                new Product
                {
                    Id = 3,
                    Name = "Laptop HP 14s-fq1080AU 4K0Z7PA (Ryzen 3-5300U/ 4GB / 256GB SSD/ 14' HD/ AMD Radeon/ Win10/ Silver/ 1 Yr)",
                    Image = "/product/imgHomepage/250-21615-hp-14s.jpg",
                    Category = "Computer",
                    ProductType = "Lap-top",
                    CPU = "AMD Ryzen™ 3-5300U (2.6GHz upto 3.8GHz, 4MB)",
                    RAM = "4GB (1x4GB) DDR4-3200Mhz (2 khe)",
                    Drive = "256GB PCIe NVMe",
                    VGA = "Radeon Vega Graphics",
                    Monitor = "14 inch HD (1366 x 768), micro-edge, BrightView, 250 nits, 45% NTSC",
                    Description = "l",
                },
                new Product
                {
                    Id = 4,
                    Name = "Laptop MSI Modern 14 B11MOU-1027VN (I3-1115G4/ 8GB RAM / 256GB SSD/ 14' FHD, 60Hz/ VGA ON/ Win11/ Grey/ 1 Yr)",
                    Image = "/product/imgHomepage/250-22706-msi-14.jpg",
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
