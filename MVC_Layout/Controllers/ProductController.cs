using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Data;
using MVC_Layout.Models.Entity;
using System.Linq;

namespace MVC_Layout.Controllers
{
    public class ProductController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Product product =  db.Products.Where(x => x.ID == id).FirstOrDefault();
            return View(product);
        }
    }
}
