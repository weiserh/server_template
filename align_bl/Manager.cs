using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace align_bl
{
    public class Manager : IManager
    {
        public Task<int> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
