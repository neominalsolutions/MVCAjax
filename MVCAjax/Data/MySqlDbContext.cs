using Microsoft.EntityFrameworkCore;

namespace MVCAjax.Data
{
  public class MySqlDbContext:DbContext
  {

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      const string connectionString = "Server=localhost;User ID=root;Password=admin; Database=ProductDB";

      optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
  }
}
