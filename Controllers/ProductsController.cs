using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private static List<Product> _products = new List<Product>(new[] {
            new Product() { Id = 1, Name = "Computer" },
            new Product() { Id = 2, Name = "Radio" },
            new Product() { Id = 3, Name = "Apple" },
        });

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }
    }
}