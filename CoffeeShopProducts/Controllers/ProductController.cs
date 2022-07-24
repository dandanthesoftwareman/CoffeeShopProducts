using CoffeeShopProducts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopProducts.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private CoffeeShopProductsDBContext context = new CoffeeShopProductsDBContext();
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<Product> result = context.Products.ToList();
            return View(result);
        }
        public IActionResult Details(int productId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == productId);
            return View(p);
        }

    }
}
