using DemoComsoleApplication.DataAccess.DAL;
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

      var useDal = new UserRepository();

      int id = useDal.CreateUser(name);

      return id;
    }

    public List<User> GetAllUsers()
    {
      var useDal = new UserRepository();
      return useDal.GetAllUsers();
    }

    public int GetUserById(int id)
    {
      var userDal = new UserRepository();
      int userId = userDal.GetUserIdById(id);
      return userId;
    }

    public int UpdateUser(string name, int id)
    {
      var userDal = new UserRepository();
      int userId = userDal.UpdateUser(name, id);
      return userId;
    }
  }
}
