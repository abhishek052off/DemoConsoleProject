using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoComsoleApplication.DataAccess.DAL;
using DemoConsoleProject.Business.CustomExections;
using DemoConsoleProject.Presentation.DAL;
using DemoConsoleProject.Presentation.DataBaseSim;

namespace DemoConsoleProject.Business.Service
{
    public class OrderService
    {
        public int CreateOrder(int userId)
        {


            //User  user = userDal.GetUserById(userId); //To make the name do what it says

            //if ( user == null )
            //{
            //    userDal.CreateUser("Random User");
            //}
            var userDal = new UserDal();
            bool isUserPresent = userDal.IsUserExists(userId);

            if (!isUserPresent)
            {
                userDal.CreateUser("Random User");
            }

            var orderDal = new OrderDal();
            int id = orderDal.CreateOrder(userId);
            return id;
        }

        public int CreateOrderWithError(int userId)
        {


            //User  user = userDal.GetUserById(userId); //To make the name do what it says

            //if ( user == null )
            //{
            //    userDal.CreateUser("Random User");
            //}
            var userDal = new UserDal();
            bool isUserPresent = userDal.IsUserExists(userId);

            if (!isUserPresent)
            {
               throw new UserNotFoundException(userId);
            }

            var orderDal = new OrderDal();
            int id = orderDal.CreateOrder(userId);
            return id;
        }
    }
}
