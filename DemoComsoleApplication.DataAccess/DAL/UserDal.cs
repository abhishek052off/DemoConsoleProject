
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Presentation.DAL
{
    public class UserDal //Repository
    {
        //CRUD

        public int CreateUser(string name)
        {
           
            var user = new User();
            user.Name = name;
            user.Id = new Random().Next(1, 1000);

            //Save to DB

            User.Users.Add(user);

            return user.Id;

            //SQL query 
            //Hit the DB 
        }

        public int UpdateUser(string name,int id) 
        {
            var user = User.Users.Where(x => x.Id == id).FirstOrDefault();
            user.Name = name;
            return user.Id;
        }

        public List<User> GetAllUsers()
        {
            //SQL = "SELECT * FROM Users"
            //MAP the users to your localk user model 
            //Return the list of users 

            var users = User.Users;
            return users;
        }
    }
}
