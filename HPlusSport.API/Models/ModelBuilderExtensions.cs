using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Active Wear - men" },
            new Category { Id = 2, Name = "Active Wear - Women" },
            new Category { Id = 3, Name = "Mineral Water" },
            new Category { Id = 4, Name = "Publications" },
            new Category { Id = 5, Name = "Supplements" }
            );

            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, CategoryId = 1, Name = "Active Wear - men",  Description = "This is mens Wear", IsAvailable = true, Price = 90, Sku = "te" },
                    new Product { Id = 2, CategoryId = 1, Name = "Active Wear - men",  Description = "This is mens Wear", IsAvailable = true, Price = 90, Sku = "te" },
                    new Product { Id = 3, CategoryId = 1, Name = "Active Wear - men",  Description = "This is mens Wear", IsAvailable = true, Price = 90, Sku = "te" },
                    new Product { Id = 4, CategoryId = 2, Name = "Active Wear - Women",  Description = "This is Womens Wear", IsAvailable = true, Price = 120, Sku = "te" },
                    new Product { Id = 5, CategoryId = 2, Name = "Active Wear - Women",  Description = "This is Womens Wear", IsAvailable = true, Price = 120, Sku = "te" },
                    new Product { Id = 6, CategoryId = 2, Name = "Active Wear - Women",  Description = "This is Womens Wear", IsAvailable = true, Price = 120, Sku = "te" },
                    new Product { Id = 7, CategoryId = 3, Name = "G",  Description = "This is Mineral Water", IsAvailable = true, Price = 20, Sku = "te" },
                    new Product { Id = 8, CategoryId = 3, Name = "G",  Description = "This is Mineral Water", IsAvailable = true, Price = 20, Sku = "te" },
                    new Product { Id = 9, CategoryId = 3, Name = "G",  Description = "This is Mineral Water", IsAvailable = true, Price = 20, Sku = "te" },
                    new Product { Id = 10, CategoryId = 4, Name = "G",  Description = "This is Publications", IsAvailable = true, Price = 80, Sku = "te" },
                    new Product { Id = 11, CategoryId = 4, Name = "G",  Description = "This is Publications", IsAvailable = true, Price = 80, Sku = "te" },
                    new Product { Id = 12, CategoryId = 4, Name = "G",  Description = "This is Publications", IsAvailable = true, Price = 80, Sku = "te" },
                    new Product { Id = 13, CategoryId = 5, Name = "G",  Description = "This is Supplements", IsAvailable = true, Price = 40, Sku = "te" },
                    new Product { Id = 14, CategoryId = 5, Name = "G",  Description = "This is Supplements", IsAvailable = true, Price = 40, Sku = "te" },
                    new Product { Id = 15, CategoryId = 5, Name = "G",  Description = "This is Supplements", IsAvailable = true, Price = 40, Sku = "te" }

                );

           
        }
    }
}
