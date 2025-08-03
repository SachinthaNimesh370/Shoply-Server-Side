using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shoply_Server_Side.Models;

namespace Shoply_Data_Access
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=ShoplyDb;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Treat Rating as an owned/embedded type inside Product
            modelBuilder.Entity<Product>().OwnsOne(p => p.Rating);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", Price = 109.95, Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday", Category = "men's clothing", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg" },
                new Product { Id = 2, Title = "Mens Casual Premium Slim Fit T-Shirts ", Price = 22.3, Description = "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.", Category = "men's clothing", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg" },
                new Product { Id = 3, Title = "Mens Cotton Jacket", Price = 55.99, Description = "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm-hearted love to Father, husband or son in this thanksgiving or Christmas Day.", Category = "men's clothing", Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg" },
                new Product { Id = 4, Title = "Mens Casual Slim Fit", Price = 15.99, Description = "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.", Category = "men's clothing", Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg" },
                new Product { Id = 5, Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", Price = 695, Description = "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.", Category = "jewelery", Image = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg" },
                new Product { Id = 6, Title = "Solid Gold Petite Micropave ", Price = 168, Description = "Satisfaction Guaranteed. Return or exchange any order within 30 days. Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed.", Category = "jewelery", Image = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg" },
                new Product { Id = 7, Title = "White Gold Plated Princess", Price = 9.99, Description = "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...", Category = "jewelery", Image = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg" },
                new Product { Id = 8, Title = "Pierced Owl Rose Gold Plated Stainless Steel Double", Price = 10.99, Description = "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel", Category = "jewelery", Image = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg" },
                new Product { Id = 9, Title = "WD 2TB Elements Portable External Hard Drive - USB 3.0 ", Price = 64, Description = "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatible with Windows 7, 8, 10; May require reformatting for other operating systems", Category = "electronics", Image = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg" },
                new Product { Id = 10, Title = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", Price = 109, Description = "Easy upgrade for faster boot up, shutdown, application load and response. Boosts burst write performance, making it ideal for typical PC workloads.", Category = "electronics", Image = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg" },
                new Product { Id = 11, Title = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III", Price = 109, Description = "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. High efficiency performance - low power consumption. Support for TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.", Category = "electronics", Image = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg" },
                new Product { Id = 12, Title = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", Price = 114, Description = "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty", Category = "electronics", Image = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg" },
                new Product { Id = 13, Title = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", Price = 599, Description = "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount. Refresh Rate: 75Hz - Using HDMI port", Category = "electronics", Image = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg" },
                new Product { Id = 14, Title = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor", Price = 999.99, Description = "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen side by side. Quantum dot (QLED) technology, HDR support and factory calibration provide stunningly realistic and accurate color and contrast. Advanced gaming features include fast 144Hz refresh rate and 1ms motion blur reduction (MPRT) for incredibly smooth motion scenes.", Category = "electronics", Image = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg" },
                new Product { Id = 15, Title = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", Price = 56.99, Description = "Note: The Jackets is US standard size, Please choose size as your usual wear Material: 100% Polyester; Detachable Liner Fabric: Warm Fleece.", Category = "women's clothing", Image = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg" },
                new Product { Id = 16, Title = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", Price = 29.95, Description = "100% POLYURETHANE (shell) 100% POLYESTER (lining) 75% POLYESTER 25% COTTON (sweater), Faux leather material for style and comfort / 2 pockets of front, detail stitching at sides", Category = "women's clothing", Image = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg" },
                new Product { Id = 17, Title = "Rain Jacket Women Windbreaker Striped Climbing Raincoats", Price = 39.99, Description = "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design.", Category = "women's clothing", Image = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg" },
                new Product { Id = 18, Title = "MBJ Women's Solid Short Sleeve Boat Neck V", Price = 9.85, Description = "95% RAYON 5% SPANDEX", Category = "women's clothing", Image = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg" },
                new Product { Id = 19, Title = "Opna Women's Short Sleeve Moisture", Price = 7.95, Description = "100% Polyester Moisture Transport System sweeps away sweat and dries quickly", Category = "women's clothing", Image = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg" },
                new Product { Id = 20, Title = "DANVOUY Womens T Shirt Casual Cotton Short", Price = 12.99, Description = "95%Cotton,5%Spandex", Category = "women's clothing", Image = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg" }
            );

            modelBuilder.Entity<Product>().OwnsOne(p => p.Rating).HasData(
                new { ProductId = 1, Rate = 3.9, Count = 120 },
                new { ProductId = 2, Rate = 4.1, Count = 259 },
                new { ProductId = 3, Rate = 4.7, Count = 500 },
                new { ProductId = 4, Rate = 2.1, Count = 430 },
                new { ProductId = 5, Rate = 4.6, Count = 400 },
                new { ProductId = 6, Rate = 3.9, Count = 70 },
                new { ProductId = 7, Rate = 3.0, Count = 400 },
                new { ProductId = 8, Rate = 1.9, Count = 100 },
                new { ProductId = 9, Rate = 3.3, Count = 203 },
                new { ProductId = 10, Rate = 2.9, Count = 470 },
                new { ProductId = 11, Rate = 4.8, Count = 319 },
                new { ProductId = 12, Rate = 4.8, Count = 400 },
                new { ProductId = 13, Rate = 2.9, Count = 250 },
                new { ProductId = 14, Rate = 2.2, Count = 140 },
                new { ProductId = 15, Rate = 2.6, Count = 235 },
                new { ProductId = 16, Rate = 2.9, Count = 340 },
                new { ProductId = 17, Rate = 3.8, Count = 679 },
                new { ProductId = 18, Rate = 4.7, Count = 130 },
                new { ProductId = 19, Rate = 4.5, Count = 146 },
                new { ProductId = 20, Rate = 3.6, Count = 145 }
            );

        }
    }
}
