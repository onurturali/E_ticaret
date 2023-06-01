using Microsoft.AspNetCore.Mvc;
using Eticaret.Model;

namespace Eticaret.Magaza.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ Id = 0, Name = "Laptop", Price = 30500 },
                new Product(){ Id = 1, Name = "Mobile Phone", Price = 10000 },
                new Product(){ Id = 3, Name = "Çamaır makines", Price = 20000 },
            };

            return View(products);
        }
    }
}
