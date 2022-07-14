using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Model;
using Services.Interfaces;

namespace OnlineStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductInterface _productService;

        public ProductController(IProductInterface productInterface)
        {
            _productService = productInterface;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProducts();
            return Ok(result);
        }

        [HttpPut("createProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            throw new NotImplementedException();
        }

        [HttpPost("updateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            throw new NotImplementedException();
        }
    }
}
