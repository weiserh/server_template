using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace align_bl
{
    public class Manager : IManager
    {
        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
