using Microsoft.EntityFrameworkCore;
using TheMask.Models;

namespace TheMask.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        //Data Seeding

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    ProductName = "Mask Eyebrow Set",
                    ProductCategory = "Makeup",
                    ProductImage = "maskeyebrowset",
                    ProductPrice = 100,
                    ProductDescription = "Enhance your natural beauty with our premium eyebrow set tool, designed to effortlessly shape and define your brows. Crafted for precision and ease,\r\n                                    this versatile tool ensures flawless brows that perfectly complement your makeup look."
                },

                new Product()
                {
                    Id = 2,
                    ProductName = "Mask Lipstick",
                    ProductCategory = "Makeup",
                    ProductImage = "masklipstick",
                    ProductPrice = 125,
                    ProductDescription = "Elevate your glamour game with our captivating red lipstick. A timeless classic, this bold shade exudes confidence and allure,\r\n                                    while our formula ensures a comfortable and vibrant wear that turns heads wherever you go.",
                },

                new Product()
                {
                    Id = 3,
                    ProductName = "Mask Foundation",
                    ProductCategory = "Makeup",
                    ProductImage = "maskfoundation",
                    ProductPrice = 175,
                    ProductDescription = "Unveil a radiant complexion with our luxurious powder foundation. Providing coverage and a seamless finish, effortlessly blur our imperfections\r\n                                    while letting your skin breathe, leaving you with a flawless and natural-looking glow.",
                },

                new Product()
                {
                    Id = 4,
                    ProductName = "Mask Serum",
                    ProductCategory = "Skincare",
                    ProductImage = "maskserum",
                    ProductPrice = 250,
                    ProductDescription = "Experience a transformation in your skincare routine with our rejuvenating serum. Packed with potent\r\n                                    antioxidants and nourishing ingredients, this serum delivers deep hydration and targets fine lines and uneven texture.",
                },

                new Product()
                {
                    Id = 5,
                    ProductName = "Mask Moisturizer",
                    ProductCategory = "Skincare",
                    ProductImage = "maskmoisturizer",
                    ProductPrice = 225,
                    ProductDescription = "Indulge your skin in the ultimate hydration experience with our enriching moisturizer. Infused with a harmonious blend of nourishing oils and skin-loving vitamins,\r\n                                    this moisturizer revitalizes and restores your skin's natural radiance.",
                },

                new Product()
                {
                    Id = 6,
                    ProductName = "Mask Sunscreen",
                    ProductCategory = "Skincare",
                    ProductImage = "masksunscreen",
                    ProductPrice = 200,
                    ProductDescription = "Unveil a radiant complexion with our luxurious powder foundation. Providing coverage and a seamless finish, effortlessly blur our imperfections\r\n                                    while letting your skin breathe, leaving you with a flawless and natural-looking glow.",
                });
        }
    }
}
