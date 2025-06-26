using DemoConsoleProject.Presentation.DataBaseSim;
using System.Collections.Generic;

namespace DemoConsoleProject.Presentation.DAL
{
    public interface IUserDataAccess
    {
        int CreateUser(string name);
        List<User> GetAllUsers();
        User GetUserById(int id);
        int GetUserIdById(int id);
        bool IsUserExists(int id);
        int UpdateUser(string name, int id);
    }


    
}