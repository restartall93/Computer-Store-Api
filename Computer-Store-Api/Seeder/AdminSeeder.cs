using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Computer_Store_Api.Seeder
{
    public class AdminSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public AdminSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<Admin>().HasData(
                new Admin {
                    Id = 1,
                    Name = "Admin",
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    PassWord = "admin"
                }
                ) ;
        }
    }
}
