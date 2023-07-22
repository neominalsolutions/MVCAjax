using MVCAjax.Data;

namespace MVCAjax.Repositories
{
  public class ProductPostgreSqlRepository : RepositoryBase<PostgreSqlDbContext, Product>, IProductRepository
  {
    public ProductPostgreSqlRepository(PostgreSqlDbContext db) : base(db)
    {
    }

    public List<Product> IncludeByCategory()
    {
      throw new NotImplementedException();
    }
  }
}
