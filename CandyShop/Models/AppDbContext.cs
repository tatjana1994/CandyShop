using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CandyShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
          
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chocolate Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gummy Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Halloween Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Hard Candy" });



            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 1,
                Name = "Assorted Chocolate Candy",
                Price = 4.95M,
                Description = "As a chic party planner you know it’s only right to seal each event with a kiss -- a Hershey’s Kiss, that is. Perfect for the birthday girl who doesn’t like leaving guests empty-handed, this four-pound bag of pink-wrapped Hershey Kisses will give her something to send them home with. After unwrapping the pink foil to experience the smooth milk chocolate, everyone will forget all about that kiss on the cheek they were expecting because their little chocolate kiss has way more flavor.",
                CategoryId = 1,
                ImageUrl = "\\Images\\ChocolateCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 2,
                Name = "Another Assorted Chocolate Candy",
                Price = 3.95M,
                Description = "Each silky smooth bite of rich dark chocolate transports your taste buds to a mysterious dark chocolate dream world, whisking you away to an opulent snack-time paradise as it melts upon your tongue. Unwrap a square of Dove’s Dark Chocolate perfection and prepare to experience the sensation like never before. Who says you should be scared of the dark?",
                CategoryId = 1,
                ImageUrl = "\\Images\\ChocolateCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 3,
                Name = "Another Chocolate Candy",
                Price = 5.75M,
                Description = "Want to feel like a million bucks? Dive into a box of decadence and say yes to the ultimate marriage of luscious milk chocolate and tangy berry sweetness. Each delicate candy indulgence swaddles your taste buds in delight as wild berry tartness mingles with an intoxicating dark chocolate essence. Treat yourself, you've earned it!",
                CategoryId = 1,
                ImageUrl = "\\Images\\ChocolateCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 4,
                Name = "Assorted Fruit Candy",
                Price = 3.95M,
                Description = "Jujyfruits are the famous candy manufactured by Heide.  Why do I say famous?  Because jujyfruits and their friend the jujubees are often thought of when older generations of Americans mention movie candy. This is the original version.",
                CategoryId = 2,
                ImageUrl = "\\Images\\FruitCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 5,
                Name = "Fruit Candy",
                Price = 7.00M,
                Description = "The old fashioned gum drops you remember!  These plump jelly retro candies come in a variety of fruit flavors and are of a perfect texture.  Don't forget that they are coated in tasty sugar crystals!",
                CategoryId = 2,
                ImageUrl = "\\Images\\FruitCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 6,
                Name = "Another Assorted Fruit Candy",
                Price = 11.25M,
                Description = "Tropical Gummy Drops are sweet and tangy with a tropical flavor. The drops are layered with red, yellow, and blue colors. ",
                CategoryId = 2,
                ImageUrl = "\\Images\\FruitCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 7,
                Name = "Assorted Gummy Candy",
                Price = 3.95M,
                Description = "Sour Patch Kids are as cute as they are delicious. The chewy candies start out sour enough to make you squint, but quickly turn sweet! Have fun sharing these with friends or eating them all yourself!  A combination of colors and flavors such as Apple, Cherry, Orange and Lemon. ",
                CategoryId = 3,
                ImageUrl = "\\Images\\GummyCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 8,
                Name = "Another Assorted Gummy Candy",
                Price = 1.95M,
                Description = "Gummy candy is a unique E-Liquid that will remind you of that delicious, creepy crawly treat. A taste of the sweet gummy worms with assorted tropical, fruity flavors.",
                CategoryId = 3,
                ImageUrl = "\\Images\\GummyCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 9,
                Name = "Gummy Candy",
                Price = 13.95M,
                Description = "Arrange the brightly colored heart candies in candy buffet containers, or include them in individually wrapped wedding favors.",
                CategoryId = 3,
                ImageUrl = "\\Images\\GummyCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 10,
                Name = "Halloween Candy",
                Price = 1.95M,
                Description = "A little ghost or goblin receives poison candy while trick or treating and is harmed with physical and mental scars, or worse yet, fails to survive at all. These stories come in many forms right around the Halloween season. Newspaper and magazine stories repeat the annual warnings.",
                CategoryId = 4,
                ImageUrl = "\\Images\\HalloweenCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 11,
                Name = "Assorted Halloween Candy",
                Price = 12.95M,
                Description = "Perfectly spooky and delicious chocolate Halloween cupcakes decorated in five easy designs.",
                CategoryId = 4,
                ImageUrl = "\\Images\\HalloweenCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 12,
                Name = "Another Halloween Candy",
                Price = 21.95M,
                Description = "Get all the chocolaty goodness you can handle in this bulk candy mix! Our chocolate assortment includes a generous quantity of confections.",
                CategoryId = 4,
                ImageUrl = "\\Images\\HalloweenCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 13,
                Name = "Hard Candy",
                Price = 6.95M,
                Description = "These Delicious sour hard candy shaped as a ball, gives you long lasting flavor. An assortment of flavors includes: Orange, Grape, Lemon, Lime and Cherry. The colors of red, orange, yellow, green and purple make a lovely addition to a rainbow-themed party or candy buffet.",
                CategoryId = 5,
                ImageUrl = "\\Images\\HardCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 14,
                Name = "Another Hard Candy",
                Price = 2.95M,
                Description = "It's one of the oldest old-fashioned holiday candies out there. So many of us sadly grew up thinking this was 'fancy' candy, and explaining away why we shouldn't be able to enjoy it.",
                CategoryId = 5,
                ImageUrl = "\\Images\\HardCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 15,
                Name = "Best Hard Candy",
                Price = 16.95M,
                Description = "Cut Rock Hard Candy is as much a cultural experience as it is a tasty treat! And with its relatively small pieces, portion control is simple! Of course, with its about-a-million flavors, there's a lot of picking, choosing, and compromising to be done.",
                CategoryId = 5,
                ImageUrl = "\\Images\\HardCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}