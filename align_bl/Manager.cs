using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace align_bl
{
    public class Manager : IManager
    {
        private DbAccessor _dbAccessor;

       // public Manager(IDbAccessor dbAccessor)
        public Manager()
        {
            _dbAccessor = new DbAccessor();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbAccessor.GetProducts();
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
