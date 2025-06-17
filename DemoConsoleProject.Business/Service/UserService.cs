using DemoConsoleProject.Presentation.DAL;
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Business.Service
{
    public class UserService
    {

        public int CreateUser(string name)
        {

            var useDal = new UserDal();

            int id = useDal.CreateUser(name);

            return id;
        }

        public List<User> GetAllUsers()
        {
            var useDal = new UserDal();
            return useDal.GetAllUsers();
        }
    }
}
