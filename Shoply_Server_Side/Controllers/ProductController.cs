using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoply_Server_Side.Models;
using Shoply_Server_Side.Services;

namespace Shoply_Server_Side.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase 
    {
        private ProductService _productService;

        //constructor
        public ProductController(ProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.products());
        }

        [HttpGet("search")]
        public IActionResult searchProducts([FromQuery] int? id)
        {
            if (id is null)
                return Ok(_productService.products());

            var list = _productService.products().Where(t => t.Id == id).ToList();
            return Ok(list);
        }


    }
}
