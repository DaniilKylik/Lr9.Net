using Microsoft.AspNetCore.Mvc;
using Lr9.Net.Models;
using System;
using System.Collections.Generic;

namespace Lr9.Net.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 10.5m, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Product 2", Price = 20.0m, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 3, Name = "Product 3", Price = 30.75m, CreatedDate = DateTime.Now.AddDays(-2) }
            };

            return View(products);
        }
    }
}
