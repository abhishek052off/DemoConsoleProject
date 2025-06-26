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
        private readonly UserRepository _userRepo;

        public UserService()
        {
            _userRepo = new UserRepository();
        }

        public int CreateUser(string name)
        {
            var user = new User
            {
                Name = name
            };
           
            User user2 = _userRepo.Create(user);

            return user2.Id;
        }

        public List<User> GetAllUsers()
        {

            return _userRepo.GetAllUsers();
        }

        public int GetUserById(int id)
        {

            int userId = _userRepo.GetUserIdById(id);
            return userId;
        }

        public int UpdateUser(string name, int id)
        {
            int userId = _userRepo.UpdateUser(name, id);
            return userId;
        }
    }
}
