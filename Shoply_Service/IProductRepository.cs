using Shoply_Server_Side.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoply_Service
{
    internal interface IProductRepository
    {
        public List<Product> products();
        
    }
}
