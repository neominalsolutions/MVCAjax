using MVCAjax.Data;

namespace MVCAjax.Repositories
{
  public interface IProductRepository:IRepository<Product>
  {

    List<Product> IncludeByCategory();

  }
}
