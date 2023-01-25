using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Data;
using System.Linq;

namespace MVC_Layout.Controllers
{
    public class CategoryController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public IActionResult Details(int id)//2
        {
            System.Collections.Generic.List<Models.Entity.Product> products = db.Products.Where(x => x.Category.ID == id).ToList();
            return View(products);
        }
    }
}
