using System.Linq.Expressions;

namespace MVCAjax.Repositories
{
  public interface IRepository<T> where T:class
  {

    /// <summary>
    /// T tipindeki class create et
    /// </summary>
    /// <param name="entity"></param>
    void Create(T entity); 

    /// <summary>
    /// T tipindeki class Update et
    /// </summary>
    /// <param name="entity"></param>
    void Update(T entity);

    /// <summary>
    /// T tipinde class idsine göre bul ve sil
    /// </summary>
    /// <param name="Id"></param>
    void Delete(string Id);

    /// <summary>
    /// T tipinde tek bir item döndür
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    T Find(string Id);

    /// <summary>
    /// Liste olarak T değerlerini döndür.
    /// </summary>
    /// <returns></returns>
    List<T> List();

    /// <summary>
    /// Filtreli list değeri
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    List<T> Where(Expression<Func<T, bool>> filter); // x => x.Id == 1

  }
}
