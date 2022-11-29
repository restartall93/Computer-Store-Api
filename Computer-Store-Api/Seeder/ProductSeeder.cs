using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;

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
                    Image = "/product/test.jpg",
                    CPU = "Intel Core i5 11400H",
                    RAM = "16gb",
                    Drive = "512GB SSD",
                    VGA = "NVIDIA RTX3050Ti 4G",
                    Monitor = "NVIDIA RTX3050Ti 4G",
                    Description = "l"

                },
                new Product
                {
                    Id = 2,
                    Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                    Image = "/product/test.jpg",
                    CPU = "Intel Core i5 11400H",
                    RAM = "16gb",
                    Drive = "512GB SSD",
                    VGA = "NVIDIA RTX3050Ti 4G",
                    Description="l",
                    Monitor = "NVIDIA RTX3050Ti 4G"
                },
                new Product
                {
                    Id = 3,
                    Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                    Image = "/product/test.jpg",
                    CPU = "Intel Core i5 11400H",
                    RAM = "16gb",
                    Drive = "512GB SSD",
                    VGA = "NVIDIA RTX3050Ti 4G",
                    Monitor = "NVIDIA RTX3050Ti 4G",
                    Description="l"
                });
        }
    }
}
