using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace align_bl
{
    public interface IManager
    {
        Task<List<Product>> GetProducts();
        Task<int> AddProduct(Product product);
    }
}
