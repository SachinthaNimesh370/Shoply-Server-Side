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
        private IProductRepository _productRepo;

        //constructor
        public ProductController(IProductRepository productRepo) 
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_productRepo.products());
        }

        [HttpGet("search")]
        public IActionResult searchProducts([FromQuery] int? id)
        {
            if (id is null)
                return Ok(_productRepo.products());

            var list = _productRepo.products().Where(t => t.Id == id).ToList();
            return Ok(list);
        }


    }
}
