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
                new Product(){ Id = 2, Name = "Çamaşır Makinesi", Price = 20000 },
            };

            return View(products);
        }

        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Product product = new() { Id = id, Name = "Buzdolabı", Price = 40000 };
            return View(product);
        }

        [Route("new")]
        public IActionResult New()
        {
            return View();
        }
    }
}
