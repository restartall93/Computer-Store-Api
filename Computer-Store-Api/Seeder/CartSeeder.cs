using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Computer_Store_Api.Seeder
{
    public class CartSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public CartSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<Cart>().HasData(
                new Cart
                {
                    Id = 1,
                    UserId = 1,
                    Quantity = 0,
                },
                new Cart
                {
                    Id = 2,
                    UserId = 2,
                    Quantity = 0,
                }
                ) ;
        }
    }
}
