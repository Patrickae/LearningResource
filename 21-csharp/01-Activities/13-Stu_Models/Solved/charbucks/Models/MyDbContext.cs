using Microsoft.EntityFrameworkCore;

namespace charbucks.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Coffee> Coffees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(@"Server=localhost;database=charbucks;uid=root;pwd=;");
        }
    }
}
