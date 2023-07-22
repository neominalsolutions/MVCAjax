using Microsoft.EntityFrameworkCore;

namespace MVCAjax.Data
{
  public class PostgreSqlDbContext:DbContext
  {

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      const string connectionString = "Server=localhost;Database=ProductDB;Port=5432;User Id=postgres;Password=admin";

      optionsBuilder.UseNpgsql(connectionString);


      base.OnConfiguring(optionsBuilder);
    }


  }
}
