using Shoply_Server_Side.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoply_Data_Access;

namespace Shoply_Server_Side.Services
{
    public class ProductSQLServer : IProductRepository
    {
        private  ProductDbContext _context;
        public ProductSQLServer(ProductDbContext context)
        {
            _context = context;
        }

        public List<Product> products()
        {
            return _context.Product.ToList();
        }
    }

}
