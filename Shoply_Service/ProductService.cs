using Shoply_Server_Side.Models;
using Shoply_Service;

namespace Shoply_Server_Side.Services
{
    public class IProductRepository : Shoply_Service.IProductRepository
    {
        public List<Product> products() {
            List<Product> list = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                    Price = 109.95,
                    Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                    Rating = new Rating { Rate = 3.9, Count = 120 }
                },
                new Product
                {
                    Id = 2,
                    Title = "Mens Casual Premium Slim Fit T-Shirts ",
                    Price = 22.3,
                    Description = "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
                    Rating = new Rating { Rate = 4.1, Count = 259 }
                },
                new Product
                {
                    Id = 3,
                    Title = "Mens Cotton Jacket",
                    Price = 55.99,
                    Description = "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions...",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                    Rating = new Rating { Rate = 4.7, Count = 500 }
                },
                new Product
                {
                    Id = 4,
                    Title = "Mens Casual Slim Fit",
                    Price = 15.99,
                    Description = "The color could be slightly different between on the screen and in practice...",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                    Rating = new Rating { Rate = 2.1, Count = 430 }
                },
                new Product
                {
                    Id = 5,
                    Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                    Price = 695,
                    Description = "From our Legends Collection, the Naga was inspired by the mythical water dragon...",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                    Rating = new Rating { Rate = 4.6, Count = 400 }
                },
                new Product
                {
                    Id = 6,
                    Title = "Solid Gold Petite Micropave ",
                    Price = 168,
                    Description = "Satisfaction Guaranteed. Return or exchange any order within 30 days...",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
                    Rating = new Rating { Rate = 3.9, Count = 70 }
                },
                new Product
                {
                    Id = 7,
                    Title = "White Gold Plated Princess",
                    Price = 9.99,
                    Description = "Classic Created Wedding Engagement Solitaire Diamond Promise Ring...",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
                    Rating = new Rating { Rate = 3.0, Count = 400 }
                },
                new Product
                {
                    Id = 8,
                    Title = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                    Price = 10.99,
                    Description = "Rose Gold Plated Double Flared Tunnel Plug Earrings...",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
                    Rating = new Rating { Rate = 1.9, Count = 100 }
                },
                new Product
                {
                    Id = 9,
                    Title = "WD 2TB Elements Portable External Hard Drive - USB 3.0 ",
                    Price = 64,
                    Description = "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg",
                    Rating = new Rating { Rate = 3.3, Count = 203 }
                },
                new Product
                {
                    Id = 10,
                    Title = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s",
                    Price = 109,
                    Description = "Easy upgrade for faster boot up, shutdown, application load and response...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg",
                    Rating = new Rating { Rate = 2.9, Count = 470 }
                },
                new Product
                {
                    Id = 11,
                    Title = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5",
                    Price = 109,
                    Description = "3D NAND flash are applied to deliver high transfer speeds...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg",
                    Rating = new Rating { Rate = 4.8, Count = 319 }
                },
                new Product
                {
                    Id = 12,
                    Title = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive",
                    Price = 114,
                    Description = "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg",
                    Rating = new Rating { Rate = 4.8, Count = 400 }
                },
                new Product
                {
                    Id = 13,
                    Title = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin",
                    Price = 599,
                    Description = "21. 5 inches Full HD (1920 x 1080) widescreen IPS display...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg",
                    Rating = new Rating { Rate = 2.9, Count = 250 }
                },
                new Product
                {
                    Id = 14,
                    Title = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA)",
                    Price = 999.99,
                    Description = "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen...",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg",
                    Rating = new Rating { Rate = 2.2, Count = 140 }
                },
                new Product
                {
                    Id = 15,
                    Title = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats",
                    Price = 56.99,
                    Description = "Note:The Jackets is US standard size, Please choose size as your usual wear...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg",
                    Rating = new Rating { Rate = 2.6, Count = 235 }
                },
                new Product
                {
                    Id = 16,
                    Title = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket",
                    Price = 29.95,
                    Description = "100% POLYURETHANE(shell) 100% POLYESTER(lining)...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg",
                    Rating = new Rating { Rate = 2.9, Count = 340 }
                },
                new Product
                {
                    Id = 17,
                    Title = "Rain Jacket Women Windbreaker Striped Climbing Raincoats",
                    Price = 39.99,
                    Description = "Lightweight perfet for trip or casual wear---Long sleeve with hooded...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg",
                    Rating = new Rating { Rate = 3.8, Count = 679 }
                },
                new Product
                {
                    Id = 18,
                    Title = "MBJ Women's Solid Short Sleeve Boat Neck V ",
                    Price = 9.85,
                    Description = "95% RAYON 5% SPANDEX, Made in USA or Imported...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg",
                    Rating = new Rating { Rate = 4.7, Count = 130 }
                },
                new Product
                {
                    Id = 19,
                    Title = "Opna Women's Short Sleeve Moisture",
                    Price = 7.95,
                    Description = "100% Polyester, Machine wash, 100% cationic polyester interlock...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg",
                    Rating = new Rating { Rate = 4.5, Count = 146 }
                },
                new Product
                {
                    Id = 20,
                    Title = "DANVOUY Womens T Shirt Casual Cotton Short",
                    Price = 12.99,
                    Description = "95%Cotton,5%Spandex, Features: Casual, Short Sleeve, Letter Print...",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg",
                    Rating = new Rating { Rate = 3.6, Count = 145 }
                }

            };

            return list;
        
        }
            
    }
}
