using Microsoft.AspNetCore.Mvc;
using asp_net_web_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToArray();
        }
    }
}