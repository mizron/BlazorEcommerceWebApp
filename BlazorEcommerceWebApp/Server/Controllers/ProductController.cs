using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // Inject IproductService
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Get request passed through to the IProductService
        // Await response and return result to Client
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductListAsync();
            return Ok(result);
        }
    }
}
 