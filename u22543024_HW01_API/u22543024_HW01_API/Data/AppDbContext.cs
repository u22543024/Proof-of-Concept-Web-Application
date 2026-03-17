using Microsoft.EntityFrameworkCore;
using u22543024_HW01_API.Models;

namespace u22543024_HW01_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.ID);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID=1,
                    Name="Running Shoes",
                    Price = 89.99,
                    Description="High-performance running shoes designed with breathable mesh and a cushioned sole for maximum comfort and support. Features a sleek design and durable rubber outsole for traction on various surfaces."
                },
                new Product
                {
                    ID = 2,
                    Name = "Boots",
                    Price = 89.00,
                    Description = "Sleek leather boots with elastic side panels for easy wear. Features a comfortable insole and durable rubber outsole, ideal for everyday wear."
                },
                new Product
                {
                    ID = 3,
                    Name = "Baseball Cap",
                    Price = 19.99,
                    Description = "A classic baseball cap with an adjustable strap and embroidered logo. Made of breatable cotton, perfect for casual and outdoor activities."
                },
                new Product
                {
                    ID = 4,
                    Name = "Maxi Dress",
                    Price = 59.99,
                    Description = "Flowing, floor-length mix dress made from lightweight fabric. Features an adjustable strap design and a flattering A-line sihouette."
                },
                new Product
                {
                    ID = 5,
                    Name = "Slim Fit Chinos",
                    Price = 44.95,
                    Description = "A pair of slim-fit chinos made from lightweight cotton with a bit of stretch. Features a clean, modern look suitable for both work and weekend wear."
                },
                new Product
                {
                    ID = 6,
                    Name = "Hoodie",
                    Price = 49.99,
                    Description = "Cozy hoodie with a bold graphic print on the front. Made of soft cotton, perfect for lounging or casual outings."
                },
                new Product
                {
                    ID = 7,
                    Name = "Jogger Sweatpants",
                    Price = 39.99,
                    Description = "Comfortable and stylish jogger sweatpants with an elastic waistband and cuffs. Features side pockets and a soft fleece interior for extra warmth."
                },
                new Product
                {
                    ID = 8,
                    Name = "Fleece Jacket",
                    Price = 70.00,
                    Description = "A fleece jacket is a lightweight, warm, and breathable outwear piece made from synthetic material like polyster. It provides excellent insulation by trapping heat while remaing soft and comfortable. Fleece jackets are popular for outdoor activities, layering in cold casual wear due to thier moisture-wicking properties and ease of care."
                },
                new Product
                {
                    ID = 9,
                    Name = "Jeans",
                    Price = 600.00,
                    Description = "Jeans are durable pants made from from demin fabric, designed as workwear but suitable for casual and fashion wear. Feature a button or ziper fly, belt loops, and pockets. They come in various shades, from classic blue to black, white, and distressed finishes. "
                },
                new Product
                {
                    ID = 10,
                    Name = "T-Shirt",
                    Price = 67.99,
                    Description = "A T-Shirt is a casual, short-sleeved garment made from soft fabric, typically cotton. Designed with a round or V-shaped neckline, in various colours, patterns, and styles, including fitted, oversized, and grphic-printed designs."
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
