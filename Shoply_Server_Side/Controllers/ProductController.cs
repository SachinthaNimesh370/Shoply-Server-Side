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
        public ProductController(ProductService productService) 
        {
            _productService = productService;
        }


        [HttpPost("PostProducts")]
        public IActionResult Abc(Models.Product pr) 
        {
            return Ok(pr);
        }

        [HttpGet("GetAbc")]
        public String Product(String abs) { 
            return "Sachintha :" + abs;
        }

        [HttpPost]
        public String PostAbc() 
        {
            return "Post SachinthaPost";
        }

        [HttpPost("PostAbc")]
        public IActionResult actionResult(String asd) { 
            return Ok("Post SachinthaPost"+asd);
        }

        [HttpPost("allProducts")]
        public IActionResult allProducts() {
            var list = _productService.products();
            Console.WriteLine("Number of products: " + list.Count);


            return Ok(list.Count);
        }

        [HttpPost("{id?}")]
        public IActionResult searchProducts(int? id)
        {

            if (id is null) return Ok(_productService.products);
            var list = _productService.products().Where(t => t.Id == id).ToList();

            return Ok(list);
        }


    }
}
