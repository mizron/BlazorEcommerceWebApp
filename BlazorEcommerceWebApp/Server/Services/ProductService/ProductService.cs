namespace BlazorEcommerceWebApp.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        // inject data context
        public ProductService(DataContext context)
        {
            _context = context;
        }
        
        // Implement interface method
        // Get a list of products from the data context
        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }
    }
}
