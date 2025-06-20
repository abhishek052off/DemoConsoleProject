using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoComsoleApplication.DataAccess.DAL;

namespace DemoConsoleProject.Business.Service
{
  public class OrderService
  {
    public int CreateOrder(int userId)
    {
      var orderDal = new OrderDal();
      int id = orderDal.CreateOrder(userId);
      return id;
    }
  }
}
