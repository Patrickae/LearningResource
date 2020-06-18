using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(@"Server=localhost;database=books;uid=root;pwd=;");
        }
    }
}