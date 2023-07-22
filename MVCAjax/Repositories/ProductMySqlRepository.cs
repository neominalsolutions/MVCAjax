using MVCAjax.Data;

namespace MVCAjax.Repositories
{
  public class ProductMySqlRepository : RepositoryBase<MySqlDbContext, Product>, IProductRepository
  {
    public ProductMySqlRepository(MySqlDbContext db) : base(db)
    {
    }

    public List<Product> IncludeByCategory()
    {
      throw new NotImplementedException();
    }
  }
}
