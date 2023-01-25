using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Data;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Repository;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();


        private ICategory _categoryService;
        private  IProduct _productService;
        private IAccount _accountService;

        public HomeController(ICategory categoryService, IProduct productService,IAccount accountService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _accountService = accountService;
        }


        public IActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetCategories();
            return View(_productService.GetProducts());
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string password)
        {
            if (_accountService.Authenticate(Username, password))
            {
                ViewBag.Authenticate = "Hesaba girildi!";
            }
            else
            {
                ViewBag.Authenticate = "Hesap bulunamadı!";
            };
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Account account)
        {
            _accountService.CreateAccount(account);
            return View();
        }

        public IActionResult CreateProduct() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            ViewBag.Message = _productService.CreateProduct(product);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}
