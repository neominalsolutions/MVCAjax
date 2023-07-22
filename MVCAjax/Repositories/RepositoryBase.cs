using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace MVCAjax.Repositories
{
  // TCOntext EF DbContext sınıfından türemelidir.
  public abstract class RepositoryBase<TContext, TEntity> : IRepository<TEntity>
    where TContext : DbContext
    where TEntity : class
  {
    // kalıtım alan sınıflar erişsin diye protected yaptık
    protected TContext db;
    protected DbSet<TEntity> dbSet;

    protected RepositoryBase(TContext db)
    {
      this.db = db; // database bağlantısı
      this.dbSet = db.Set<TEntity>(); // tablo bağlantısı
    }


    public virtual void Create(TEntity entity)
    {
      //db.Set<TEntity>().Add(entity);
      dbSet.Add(entity);
      Save();
      // db.products.add();
    }

    public virtual void Delete(string Id)
    {
      var entity = dbSet.Find(Id); // önce bul sonra sil
      if (entity is not null)
      {
        dbSet.Remove(entity);
        Save();
      }
      else
        throw new Exception("Hata");
    }

    public virtual TEntity Find(string Id)
    {
      return dbSet.Find(Id);
    }

    public virtual List<TEntity> List()
    {
      return dbSet.ToList();
    }

    public virtual void Update(TEntity entity)
    {
      dbSet.Update(entity);
      Save();
    }

    public List<TEntity> Where(Expression<Func<TEntity, bool>> filter)
    {
      return dbSet.Where(filter).ToList();
    }

    private void Save()
    {
      db.SaveChanges();
    }
  }
}
