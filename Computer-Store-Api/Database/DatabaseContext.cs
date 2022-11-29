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

        public static void UpdateDatabase(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=computer_store;Uid=root;Pwd=;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                    MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);

            new ProductSeeder(modelBuilder).SeedData();
        }
    }
}
