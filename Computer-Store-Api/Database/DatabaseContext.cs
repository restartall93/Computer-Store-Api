using Computer_Store_Api.Models;
using Computer_Store_Api.Seeder;
using Microsoft.EntityFrameworkCore;

namespace Computer_Store_Api.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        #region product
        public DbSet<Product> products { get; set; }
        #endregion

        #region user
        public DbSet<User> users { get; set; }
        #endregion

        #region cart
        public DbSet<Cart> carts { get; set; }
        #endregion

        #region CartDetail
        public DbSet<CartDetail> cart_details { get; set; }
        #endregion

        public static void UpdateDatabase(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=computer_store;Uid=root;Pwd=habin2001;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                    MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);

            new ProductSeeder(modelBuilder).SeedData();
            new UserSeeder(modelBuilder).SeedData();
            new CartSeeder(modelBuilder).SeedData();
        }
    }
}
