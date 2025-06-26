using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoComsoleApplication.DataAccess.DataBaseSim;

namespace DemoComsoleApplication.DataAccess.DAL
{
    public class OrderDal : IOrderDataAccess
    {
        public int CreateOrder(int userId)
        {
            var order = new Order()
            {
                Id = new Random().Next(1, 1000),
                UserId = userId
            };
            return order.Id;
        }
    }
}
