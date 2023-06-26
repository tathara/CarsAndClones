using Microsoft.EntityFrameworkCore;

namespace CarsAndClones.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CarsAndClones.db");
        }

        public DbSet<CarEntity> Cars => Set<CarEntity>();
        public DatabaseContext() => Database.EnsureCreated();
    }
}
