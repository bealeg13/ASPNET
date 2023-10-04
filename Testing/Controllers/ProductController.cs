using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }


        
    }
}
