using Microsoft.AspNetCore.Mvc;
using MVCAjax.Data;
using System.Globalization;

namespace MVCAjax.Controllers
{
  public class ProductController : Controller
  {
    public IActionResult Index()
    {
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
