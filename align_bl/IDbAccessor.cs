using System.Collections.Generic;
using System.Threading.Tasks;

namespace align_bl
{
    public interface IDbAccessor
    {
        Task<List<Product>> GetProducts();
        Task<int> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}