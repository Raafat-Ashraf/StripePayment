using Microsoft.EntityFrameworkCore;
using StripPayment.Shared.Models;

namespace StripPayment.Server.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        const int amountOfProductsToSeed = 20;

        var productsToSeed = new Product[amountOfProductsToSeed];

        for (var i = 0; i < amountOfProductsToSeed; i++)
        {
            productsToSeed[i] = new Product
            {
                Id = Guid.NewGuid().ToString(),
                Title = $"Product {i}",
                Description = $"Description of product {i}, This is an amazing product with a price-quality balance you won't find anywhere else.",
                ImageUrl = $"https://picsum.photos/id/{i}/500",
                Price = 1000 + i
            };
        }

        modelBuilder.Entity<Product>().HasData(productsToSeed);
    }
}
