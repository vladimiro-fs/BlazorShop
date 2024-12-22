namespace BlazorShopApi.Context
{
    using BlazorShopApi.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add Categories
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Beauty",
                IconCSS = "fas fa-spa"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Furniture",
                IconCSS = "fas fa-couch"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Electronics",
                IconCSS = "fas fa-headphones"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Shoewear",
                IconCSS = "fas fa-shoe-prints"
            });

            // Add Products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Beauty kit",
                Description = "Kit by Natura",
                ImageUrl = "/Images/Beauty/Beleza1.png",
                Price = 100,
                Quantity = 100,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Skin kit",
                Description = "Kit by Curology",
                ImageUrl = "/Images/Beauty/Beleza2.png",
                Price = 50,
                Quantity = 45,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Coconut oil",
                Description = "Organic coconut oil",
                ImageUrl = "/Images/Beauty/Beleza3.png",
                Price = 20,
                Quantity = 30,
                CategoryId = 1
            });
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Office chair",
                Description = "Black leather chair",
                ImageUrl = "/Images/Furniture/moveis1.png",
                Price = 50,
                Quantity = 212,
                CategoryId = 2
            });
           
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Armchair",
                Description = "Comfortable armchair",
                ImageUrl = "/Images/Furniture/moveis3.png",
                Price = 70,
                Quantity = 90,
                CategoryId = 2
            });                      

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Office lamp",
                Description = "Table lamp",
                ImageUrl = "/Images/Furniture/moveis7.png",
                Price = 20,
                Quantity = 73,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Earphones",
                Description = "Air Pods",
                ImageUrl = "/Images/Electronics/eletronico1.png",
                Price = 100,
                Quantity = 120,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Digital camera",
                Description = "Canon Digital Camera",
                ImageUrl = "/Images/Electronics/eletronico5.png",
                Price = 500,
                Quantity = 15,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Gameboy",
                Description = "Nintendo Gameboy",
                ImageUrl = "/Images/Electronics/tecnologia6.png",
                Price = 100,
                Quantity = 60,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Sneakers",
                Description = "Puma sneakers",
                ImageUrl = "/Images/Shoewear/calcado1.png",
                Price = 100,
                Quantity = 50,
                CategoryId = 4
            });
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Sneakers",
                Description = "Nike sneakers",
                ImageUrl = "/Images/Shoewear/calcado3.png",
                Price = 200,
                Quantity = 70,
                CategoryId = 4
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Sandals",
                Description = "Birkenstock sandals",
                ImageUrl = "/Images/Shoewear/calcado6.png",
                Price = 50,
                Quantity = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "John"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Janice"
            });

            // Create shopping cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1
            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2
            });
        }
    }
}
