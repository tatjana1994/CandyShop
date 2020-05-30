using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Candies",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Candy" },
                    { 2, null, "Fruit Candy" },
                    { 3, null, "Gummy Candy" },
                    { 4, null, "Halloween Candy" },
                    { 5, null, "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "As a chic party planner you know it’s only right to seal each event with a kiss -- a Hershey’s Kiss, that is. Perfect for the birthday girl who doesn’t like leaving guests empty-handed, this four-pound bag of pink-wrapped Hershey Kisses will give her something to send them home with. After unwrapping the pink foil to experience the smooth milk chocolate, everyone will forget all about that kiss on the cheek they were expecting because their little chocolate kiss has way more flavor.", "\\Images\\thumbnails\\ChocolateCandy-small", "\\Images\\ChocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 4.95m },
                    { 2, 1, "Each silky smooth bite of rich dark chocolate transports your taste buds to a mysterious dark chocolate dream world, whisking you away to an opulent snack-time paradise as it melts upon your tongue. Unwrap a square of Dove’s Dark Chocolate perfection and prepare to experience the sensation like never before. Who says you should be scared of the dark?", "\\Images\\thumbnails\\ChocolateCandy2-small.jpg", "\\Images\\ChocolateCandy2.jpg", true, true, "Another Assorted Chocolate Candy", 3.95m },
                    { 3, 1, "Want to feel like a million bucks? Dive into a box of decadence and say yes to the ultimate marriage of luscious milk chocolate and tangy berry sweetness. Each delicate candy indulgence swaddles your taste buds in delight as wild berry tartness mingles with an intoxicating dark chocolate essence. Treat yourself, you've earned it!", "\\Images\\thumbnails\\ChocolateCandy3-small.jpg", "\\Images\\ChocolateCandy3.jpg", true, false, "Another Chocolate Candy", 5.75m },
                    { 4, 2, "Jujyfruits are the famous candy manufactured by Heide.  Why do I say famous?  Because jujyfruits and their friend the jujubees are often thought of when older generations of Americans mention movie candy. This is the original version.", "\\Images\\thumbnails\\FruitCandy-small.jpg", "\\Images\\FruitCandy.jpg", true, false, "Assorted Fruit Candy", 3.95m },
                    { 5, 2, "The old fashioned gum drops you remember!  These plump jelly retro candies come in a variety of fruit flavors and are of a perfect texture.  Don't forget that they are coated in tasty sugar crystals!", "\\Images\\thumbnails\\FruitCandy2-small.jpg", "\\Images\\FruitCandy2.jpg", true, true, "Fruit Candy", 7.00m },
                    { 6, 2, "Tropical Gummy Drops are sweet and tangy with a tropical flavor. The drops are layered with red, yellow, and blue colors. ", "\\Images\\thumbnails\\FruitCandy3-small.jpg", "\\Images\\FruitCandy3.jpg", true, true, "Another Assorted Fruit Candy", 11.25m },
                    { 7, 3, "Sour Patch Kids are as cute as they are delicious. The chewy candies start out sour enough to make you squint, but quickly turn sweet! Have fun sharing these with friends or eating them all yourself!  A combination of colors and flavors such as Apple, Cherry, Orange and Lemon. ", "\\Images\\thumbnails\\GummyCandy-small.jpg", "\\Images\\GummyCandy.jpg", true, true, "Assorted Gummy Candy", 3.95m },
                    { 8, 3, "Gummy candy is a unique E-Liquid that will remind you of that delicious, creepy crawly treat. A taste of the sweet gummy worms with assorted tropical, fruity flavors.", "\\Images\\thumbnails\\GummyCandy2-small.jpg", "\\Images\\GummyCandy2.jpg", true, false, "Another Assorted Gummy Candy", 1.95m },
                    { 9, 3, "Arrange the brightly colored heart candies in candy buffet containers, or include them in individually wrapped wedding favors. ", "\\Images\\thumbnails\\GummyCandy3-small.jpg", "\\Images\\GummyCandy3.jpg", true, false, "Gummy Candy", 13.95m },
                    { 10, 4, "A little ghost or goblin receives poison candy while trick or treating and is harmed with physical and mental scars, or worse yet, fails to survive at all. These stories come in many forms right around the Halloween season. Newspaper and magazine stories repeat the annual warnings.", "\\Images\\thumbnails\\HalloweenCandy-small.jpg", "\\Images\\HalloweenCandy.jpg", true, true, "Halloween Candy", 1.95m },
                    { 11, 4, "Perfectly spooky and delicious chocolate Halloween cupcakes decorated in five easy designs.", "\\Images\\thumbnails\\HalloweenCandy2-small.jpg", "\\Images\\HalloweenCandy2.jpg", true, true, "Assorted Halloween Candy", 12.95m },
                    { 12, 4, "Get all the chocolaty goodness you can handle in this bulk candy mix! Our chocolate assortment includes a generous quantity of confections.", "\\Images\\thumbnails\\HalloweenCandy3-small.jpg", "\\Images\\HalloweenCandy3.jpg", true, true, "Another Halloween Candy", 21.95m },
                    { 13, 5, "These Delicious sour hard candy shaped as a ball, gives you long lasting flavor. An assortment of flavors includes: Orange, Grape, Lemon, Lime and Cherry. The colors of red, orange, yellow, green and purple make a lovely addition to a rainbow-themed party or candy buffet.", "\\Images\\thumbnails\\HardCandy-small.jpg", "\\Images\\HardCandy.jpg", true, false, "Hard Candy", 6.95m },
                    { 14, 5, "It's one of the oldest old-fashioned holiday candies out there. So many of us sadly grew up thinking this was 'fancy' candy, and explaining away why we shouldn't be able to enjoy it.", "\\Images\\thumbnails\\HardCandy2-small.jpg", "\\Images\\HardCandy2.jpg", true, true, "Another Hard Candy", 2.95m },
                    { 15, 5, "Cut Rock Hard Candy is as much a cultural experience as it is a tasty treat! And with its relatively small pieces, portion control is simple! Of course, with its about-a-million flavors, there's a lot of picking, choosing, and compromising to be done.", "\\Images\\thumbnails\\HardCandy3-small.jpg", "\\Images\\HardCandy3.jpg", true, false, "Best Hard Candy", 16.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Candies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
