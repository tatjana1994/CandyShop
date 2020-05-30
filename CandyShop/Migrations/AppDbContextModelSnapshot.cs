﻿// <auto-generated />
using System;
using CandyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "As a chic party planner you know it’s only right to seal each event with a kiss -- a Hershey’s Kiss, that is. Perfect for the birthday girl who doesn’t like leaving guests empty-handed, this four-pound bag of pink-wrapped Hershey Kisses will give her something to send them home with. After unwrapping the pink foil to experience the smooth milk chocolate, everyone will forget all about that kiss on the cheek they were expecting because their little chocolate kiss has way more flavor.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy-small.jpg",
                            ImageUrl = "\\Images\\ChocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 1,
                            Description = "Each silky smooth bite of rich dark chocolate transports your taste buds to a mysterious dark chocolate dream world, whisking you away to an opulent snack-time paradise as it melts upon your tongue. Unwrap a square of Dove’s Dark Chocolate perfection and prepare to experience the sensation like never before. Who says you should be scared of the dark?",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy2-small.jpg",
                            ImageUrl = "\\Images\\ChocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Chocolate Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 1,
                            Description = "Want to feel like a million bucks? Dive into a box of decadence and say yes to the ultimate marriage of luscious milk chocolate and tangy berry sweetness. Each delicate candy indulgence swaddles your taste buds in delight as wild berry tartness mingles with an intoxicating dark chocolate essence. Treat yourself, you've earned it!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\ChocolateCandy3-small.jpg",
                            ImageUrl = "\\Images\\ChocolateCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Chocolate Candy",
                            Price = 5.75m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = "Jujyfruits are the famous candy manufactured by Heide.  Why do I say famous?  Because jujyfruits and their friend the jujubees are often thought of when older generations of Americans mention movie candy. This is the original version.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy-small.jpg",
                            ImageUrl = "\\Images\\FruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = "The old fashioned gum drops you remember!  These plump jelly retro candies come in a variety of fruit flavors and are of a perfect texture.  Don't forget that they are coated in tasty sugar crystals!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy2-small.jpg",
                            ImageUrl = "\\Images\\FruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Candy",
                            Price = 7.00m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = "Tropical Gummy Drops are sweet and tangy with a tropical flavor. The drops are layered with red, yellow, and blue colors.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy3-small.jpg",
                            ImageUrl = "\\Images\\FruitCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Fruit Candy",
                            Price = 11.25m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Sour Patch Kids are as cute as they are delicious. The chewy candies start out sour enough to make you squint, but quickly turn sweet! Have fun sharing these with friends or eating them all yourself!  A combination of colors and flavors such as Apple, Cherry, Orange and Lemon. ",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy-small.jpg",
                            ImageUrl = "\\Images\\GummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 3,
                            Description = "Gummy candy is a unique E-Liquid that will remind you of that delicious, creepy crawly treat. A taste of the sweet gummy worms with assorted tropical, fruity flavors.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy2-small.jpg",
                            ImageUrl = "\\Images\\GummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Assorted Gummy Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 3,
                            Description = "Arrange the brightly colored heart candies in candy buffet containers, or include them in individually wrapped wedding favors.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\GummyCandy3-small.jpg",
                            ImageUrl = "\\Images\\GummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gummy Candy",
                            Price = 13.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 4,
                            Description = "A little ghost or goblin receives poison candy while trick or treating and is harmed with physical and mental scars, or worse yet, fails to survive at all. These stories come in many forms right around the Halloween season. Newspaper and magazine stories repeat the annual warnings.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy-small.jpg",
                            ImageUrl = "\\Images\\HalloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Halloween Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 4,
                            Description = "Perfectly spooky and delicious chocolate Halloween cupcakes decorated in five easy designs.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy2-small.jpg",
                            ImageUrl = "\\Images\\HalloweenCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 12.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = "Get all the chocolaty goodness you can handle in this bulk candy mix! Our chocolate assortment includes a generous quantity of confections.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HalloweenCandy3-small.jpg",
                            ImageUrl = "\\Images\\HalloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Halloween Candy",
                            Price = 21.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 5,
                            Description = "These Delicious sour hard candy shaped as a ball, gives you long lasting flavor. An assortment of flavors includes: Orange, Grape, Lemon, Lime and Cherry. The colors of red, orange, yellow, green and purple make a lovely addition to a rainbow-themed party or candy buffet.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy-small.jpg",
                            ImageUrl = "\\Images\\HardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Hard Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 5,
                            Description = "It's one of the oldest old-fashioned holiday candies out there. So many of us sadly grew up thinking this was 'fancy' candy, and explaining away why we shouldn't be able to enjoy it.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy2-small.jpg",
                            ImageUrl = "\\Images\\HardCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Hard Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 5,
                            Description = "Cut Rock Hard Candy is as much a cultural experience as it is a tasty treat! And with its relatively small pieces, portion control is simple! Of course, with its about-a-million flavors, there's a lot of picking, choosing, and compromising to be done.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HardCandy3-small.jpg",
                            ImageUrl = "\\Images\\HardCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Best Hard Candy",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Candy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CandyId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
