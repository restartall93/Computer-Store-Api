using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Computer_Store_Api.Seeder
{
    public class UserSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public UserSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<User>().HasData(
                new User {
                    Id = 1,
                    Name = "test1",
                    Address = "HN",
                    PhoneNumber = "1",
                    UserName = "test1",
                    PassWord = "test1"
                },
                new User
                {
                    Id = 2,
                    Name = "test2",
                    Address = "HN",
                    PhoneNumber = "1",
                    UserName = "test2",
                    PassWord = "test2"
                }
                ) ;
        }
    }
}
