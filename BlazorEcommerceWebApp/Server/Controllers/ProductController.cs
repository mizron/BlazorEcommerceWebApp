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
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductList()
        {
            var result = await _productService.GetProductListAsync();
            return Ok(result);
        }

        // return a service response with a single product based on id
        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        // return a service response with all products of a category
        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);
            return Ok(result);
        }


        // search Route
        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<ServiceResponse<Product>>> SearchProducts(string searchText)
        {
            var result = await _productService.SearchProducts(searchText);
            return Ok(result);
        }
    }
}
