using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace align_bl
{
    internal class DbAccessor : IDbAccessor
    {
        //private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        //private ParkingEntities contex;
        public Task<List<Product>> GetProducts()
        {
            try
            {
                //var parkingDetails = contex.Parking.Include("Cities").Include("Streets").ToList();

                //return parkingDetails.Select(m => new ParkingDetails
                //{
                //    ParkID = m.ParkID,
                //    ParkStartDate = m.ParkStartDate,
                //    ParkEndDate = m.ParkEndDate,
                //    CityDesc = m.Cities.CityDesc,
                //    StreetDesc = m.Streets.StreetDesc

                //}).ToList();
            }
            catch (Exception)
            {
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
