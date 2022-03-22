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
            // Decalre a composite primary key for this entity type
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new {p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default" },
                new ProductType { Id = 2, Name = "E-book" },
                new ProductType { Id = 3, Name = "Paperback" },
                new ProductType { Id = 4, Name = "Hardback" },
                new ProductType { Id = 5, Name = "Disc Edition" },
                new ProductType { Id = 6, Name = "Digital Edition" },
                new ProductType { Id = 7, Name = "Series X" },
                new ProductType { Id = 8, Name = "Series S" },
                new ProductType { Id = 9, Name = "PLayStation 4" },
                new ProductType { Id = 10, Name = "PC" },
                new ProductType { Id = 11, Name = "PlayStation 5" },
                new ProductType { Id = 12, Name = "Xbox" },
                new ProductType { Id = 13, Name = "M1 Processor" },
                new ProductType { Id = 14, Name = "Intel i5 Processor" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Eleectronics",
                    Url = "electronics"
                },
                new Category
                {
                    Id = 2,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "PlayStation 5",
                    Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Xbox",
                    Description = "The Xbox Series S/X is a home video game consoles developed by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Xbox_series_X_%2850648118708%29.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Macbook Pro",
                    Description = "The MacBook Pro is a line of Macintosh notebook computers introduced in January 2006 by Apple Inc.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Late_2016_MacBook_Pro.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "Spider-Man",
                    Description = "Marvel's Spider-Man is a 2018 action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment. Based on the Marvel Comics character Spider-Man, it tells an original narrative that is inspired by the long-running comic book mythology, while also drawing from various adaptations in other media. In the main story, the super-human crime lord Mister Negative orchestrates a plot to seize control of New York City's criminal underworld. When Mister Negative threatens to release a deadly virus, Spider-Man must confront him and protect the city while dealing with the personal problems of his civilian persona, Peter Parker. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e1/Spider-Man_PS4_cover.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Title = "God of War",
                    Description = "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment (SIE). It was released worldwide on April 20, 2018, for the PlayStation 4 with a Microsoft Windows version released on January 14, 2022. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Title = "Halo Infinite",
                    Description = "Halo Infinite is a 2021 first-person shooter game developed by 343 Industries and published by Xbox Game Studios. It is the sixth mainline entry in the Halo series,[1] and the third in the Reclaimer Saga following Halo 5: Guardians (2015). The campaign follows the human supersoldier Master Chief and his fight against the enemy Banished on the Forerunner ringworld Zeta Halo, also known as Installation 07.Unlike previous installments in the series, the multiplayer portion of the game is free - to - play. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/14/Halo_Infinite.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 10,
                    Title = "Call of Duty: Vanguard",
                    Description = "Call of Duty: Vanguard is a 2021 first-person shooter game developed by Sledgehammer Games and published by Activision.[3][4] It was released on November 5 for Microsoft Windows, PlayStation 4, PlayStation 5, Xbox One, and Xbox Series X/S.[5] It serves as the 18th installment in the overall Call of Duty series. Vanguard establishes a storyline featuring the birth of the special forces to face an emerging threat at the end of the war during various theatres of World War II.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/06/Call_of_Duty_Vanguard_cover_art.jpg",
                    CategoryId = 3
                }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 5,
                    Price = 699.99m,
                    OriginalPrice = 699.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 6,
                    Price = 599.99m,
                    OriginalPrice = 599.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 7,
                    Price = 749.99m,
                    OriginalPrice = 749.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 8,
                    Price = 549.99m,
                    OriginalPrice = 549.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 13,
                    Price = 1899.99m,
                    OriginalPrice = 1899.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 14,
                    Price = 1999.99m,
                    OriginalPrice = 1999.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 3,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 4,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 2,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 3,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 4,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 9,
                    Price = 49.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 499.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 11,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 12,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 9,
                    Price = 49.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 499.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 11,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 12,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 9,
                    Price = 49.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 499.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 11,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 12,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 9,
                    Price = 49.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 499.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 11,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 12,
                    Price = 69.99m,
                    OriginalPrice = 69.99m
                }
            );

        }

        // An entity used to query and save instances of Product
        // Results in a database table of products
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<ProductVariant> ProductVariants { get; set; }


    }
}
