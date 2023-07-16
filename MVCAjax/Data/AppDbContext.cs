using Microsoft.EntityFrameworkCore;

namespace MVCAjax.Data
{
  public class AppDbContext:DbContext
  {

    public DbSet<Product> Products { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localDB)\\MyLocalDb;Database=ETicaretDB;Trusted_Connection=True;");

    }

  }
}
