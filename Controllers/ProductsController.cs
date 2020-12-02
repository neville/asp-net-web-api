using Microsoft.AspNetCore.Mvc;

namespace asp_net_web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "All OK";
        }
    }
}