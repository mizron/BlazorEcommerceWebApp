namespace BlazorEcommerceWebApp.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        
        // Get a list of products
        // Optional parameter: categoryUrl to return products based on category
        Task GetProductList(string? categoryurl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
