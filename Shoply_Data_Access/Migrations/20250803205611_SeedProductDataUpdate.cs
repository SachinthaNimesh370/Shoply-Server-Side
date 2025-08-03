using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shoply_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Description", "Image", "Price", "Title", "Rating_Count", "Rating_Rate" },
                values: new object[,]
                {
                    { 1, "men's clothing", "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday", "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", 109.95, "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", 120, 3.8999999999999999 },
                    { 2, "men's clothing", "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.", "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", 22.300000000000001, "Mens Casual Premium Slim Fit T-Shirts ", 259, 4.0999999999999996 },
                    { 3, "men's clothing", "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm-hearted love to Father, husband or son in this thanksgiving or Christmas Day.", "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", 55.990000000000002, "Mens Cotton Jacket", 500, 4.7000000000000002 },
                    { 4, "men's clothing", "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.", "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", 15.99, "Mens Casual Slim Fit", 430, 2.1000000000000001 },
                    { 5, "jewelery", "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.", "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", 695.0, "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", 400, 4.5999999999999996 },
                    { 6, "jewelery", "Satisfaction Guaranteed. Return or exchange any order within 30 days. Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed.", "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg", 168.0, "Solid Gold Petite Micropave ", 70, 3.8999999999999999 },
                    { 7, "jewelery", "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...", "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg", 9.9900000000000002, "White Gold Plated Princess", 400, 3.0 },
                    { 8, "jewelery", "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel", "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg", 10.99, "Pierced Owl Rose Gold Plated Stainless Steel Double", 100, 1.8999999999999999 },
                    { 9, "electronics", "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatible with Windows 7, 8, 10; May require reformatting for other operating systems", "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg", 64.0, "WD 2TB Elements Portable External Hard Drive - USB 3.0 ", 203, 3.2999999999999998 },
                    { 10, "electronics", "Easy upgrade for faster boot up, shutdown, application load and response. Boosts burst write performance, making it ideal for typical PC workloads.", "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg", 109.0, "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", 470, 2.8999999999999999 },
                    { 11, "electronics", "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. High efficiency performance - low power consumption. Support for TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.", "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg", 109.0, "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III", 319, 4.7999999999999998 },
                    { 12, "electronics", "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty", "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg", 114.0, "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", 400, 4.7999999999999998 },
                    { 13, "electronics", "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount. Refresh Rate: 75Hz - Using HDMI port", "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg", 599.0, "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", 250, 2.8999999999999999 },
                    { 14, "electronics", "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen side by side. Quantum dot (QLED) technology, HDR support and factory calibration provide stunningly realistic and accurate color and contrast. Advanced gaming features include fast 144Hz refresh rate and 1ms motion blur reduction (MPRT) for incredibly smooth motion scenes.", "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg", 999.99000000000001, "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor", 140, 2.2000000000000002 },
                    { 15, "women's clothing", "Note: The Jackets is US standard size, Please choose size as your usual wear Material: 100% Polyester; Detachable Liner Fabric: Warm Fleece.", "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg", 56.990000000000002, "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", 235, 2.6000000000000001 },
                    { 16, "women's clothing", "100% POLYURETHANE (shell) 100% POLYESTER (lining) 75% POLYESTER 25% COTTON (sweater), Faux leather material for style and comfort / 2 pockets of front, detail stitching at sides", "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg", 29.949999999999999, "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", 340, 2.8999999999999999 },
                    { 17, "women's clothing", "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design.", "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg", 39.990000000000002, "Rain Jacket Women Windbreaker Striped Climbing Raincoats", 679, 3.7999999999999998 },
                    { 18, "women's clothing", "95% RAYON 5% SPANDEX", "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg", 9.8499999999999996, "MBJ Women's Solid Short Sleeve Boat Neck V", 130, 4.7000000000000002 },
                    { 19, "women's clothing", "100% Polyester Moisture Transport System sweeps away sweat and dries quickly", "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg", 7.9500000000000002, "Opna Women's Short Sleeve Moisture", 146, 4.5 },
                    { 20, "women's clothing", "95%Cotton,5%Spandex", "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg", 12.99, "DANVOUY Womens T Shirt Casual Cotton Short", 145, 3.6000000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
