using Microsoft.AspNetCore.Mvc;
using MVCAjax.Data;

namespace MVCAjax.Views.Shared.Components.Product
{
  public class ProductViewComponent:ViewComponent
  {
    // control action içinde yazılan kodları view component Invoke methodu içerisinde yazıp, controller actiondan ayırdık. Bunun sebebi bir çok yerde view component çağırabiliriz.

    public IViewComponentResult Invoke(bool? liked = null)
    {

      var db = new AppDbContext();

      if(liked == null)
      {
        // bütün ürünleri listele
        var plist = db.Products.OrderBy(x => x.Name).ToList();
        return View(plist);
      }
      else
      {
        // liked true yada liked false olanları getir.
        var plist = db.Products.Where(x=> x.Liked == liked).OrderBy(x => x.Name).ToList();
        return View(plist);
      }


    }

  }
}
