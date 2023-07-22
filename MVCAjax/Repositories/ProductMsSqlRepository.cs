using MVCAjax.Data;

namespace MVCAjax.Repositories
{
  public class ProductMsSqlRepository : RepositoryBase<MsSqlDbContext, Product>, IProductRepository
  {
    public ProductMsSqlRepository(MsSqlDbContext db) : base(db)
    {
    }

    public List<Product> IncludeByCategory()
    {
      throw new NotImplementedException();
    }
  }
}
