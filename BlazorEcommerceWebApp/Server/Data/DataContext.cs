namespace BlazorEcommerceWebApp.Server.Data
{
    // Represents a session with the database
    // Can be used to query and save instances of our entities
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "PlayStation 5",
                        Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png",
                        Price = 699.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Xbox Series X",
                        Description = "The Xbox Series X is a home video game consoles developed by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Xbox_series_X_%2850648118708%29.jpg",
                        Price = 599.99m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Macbook Pro",
                        Description = "The MacBook Pro is a line of Macintosh notebook computers introduced in January 2006 by Apple Inc.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Late_2016_MacBook_Pro.jpg",
                        Price = 1799.99m
                    }
                );
        }

        // An entity used to query and save instances of Product
        // Results in a database table of products
        public DbSet<Product> Products { get; set; }
    }
}
