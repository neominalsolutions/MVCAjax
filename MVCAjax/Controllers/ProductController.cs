using Microsoft.AspNetCore.Mvc;
using MVCAjax.Data;
using MVCAjax.Repositories;
using System.Globalization;

namespace MVCAjax.Controllers
{
  public class ProductController : Controller
  {
    private IProductRepository productRepository;

    public ProductController(IProductRepository productRepository)
    {
      this.productRepository = productRepository;
    }

    public IActionResult Index()
    {
      var product = new Product();
      product.Name = "Ürün Repo-1";
      product.Price = 10;
      product.Stock = 10;
      product.Liked = true;

      productRepository.Create(product);


      return View();
    }

    [HttpPost]
    public IActionResult Filter([FromBody] bool? selectedValue)
    {
      return ViewComponent("Product", new { liked = selectedValue });
    }


    //[HttpPost]
    //public IActionResult Filter2([FromBody] bool? selectedValue)
    //{
    //  var db = new AppDbContext();
    //  var plist = db.Products.Where(x => x.Liked == selectedValue).ToList();

    //  return Json(plist);
    //}

  }
}
