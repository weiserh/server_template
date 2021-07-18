using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace align_bl
{
    internal class DbAccessor : IDbAccessor
    {
        private ProductContext _context;
        public DbAccessor()
        {
            _context = new ProductContext();
        }
        //private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public async Task<List<Product>> GetProducts()
        {
            try
            {
                return _context.Products.ToList();

                //return productList.Select(m => new Product
                //{
                //    Id = m.Id,
                //    ParkStartDate = m.ParkStartDate,
                //    ParkEndDate = m.ParkEndDate,
                //    CityDesc = m.Cities.CityDesc,
                //    StreetDesc = m.Streets.StreetDesc

                //}).ToList();
            }
            catch (Exception ex)
            {
                var error = ex;
                //Logger.Error(ex.Message, ex.StackTrace);
            }
            return null;
        }

        public Task<int> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
