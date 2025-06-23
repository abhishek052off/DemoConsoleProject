
using DemoComsoleApplication.DataAccess.DataBaseSim;
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Presentation.DAL
{
    public class UserDal : IUserDataAccess
    //Repository
    {
        //CRUD

        public int CreateUser(string name)
        {

            var user = new User();
            user.Name = name;
            user.Id = new Random().Next(1, 1000);

            //Save to DB

            UserDBNolongerUsed.Users.Add(user);

            return user.Id;

            //SQL query 
            //Hit the DB 

            //-------------Dispoing the Resource-----------------

            //var dbContext = new AppDbContext();

            //try
            //{


            //    var user = new User()
            //    {
            //        Name = name,
            //    };

            //    dbContext.Users.Add(user);

            //    dbContext.SaveChanges(); //Exceptions 

            //    dbContext.Dispose();

            //    return user.Id;
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //}


            //using(var dbContext = new AppDbContext()) 
            //{
            //    var user = new User()
            //    {
            //        Name = name,
            //    };

            //    dbContext.Users.Add(user);

            //    dbContext.SaveChanges(); //Exceptions 

            //    return user.Id;
            //} //Always call the Dispose Method of the resource 

            //Every Unmanaged resource , follows a contract 


        }

        public int UpdateUser(string name, int id)
        {
            var user = UserDBNolongerUsed.Users.Where(x => x.Id == id).FirstOrDefault();
            user.Name = name;
            return user.Id;
        }

        public List<User> GetAllUsers()
        {
            //SQL = "SELECT * FROM Users"
            //MAP the users to your localk user model 
            //Return the list of users 

            var users = UserDBNolongerUsed.Users;
            return users;
        }

        public User GetUserById(int id)
        {
            var user = UserDBNolongerUsed.Users.Where(x => x.Id == id).FirstOrDefault(); // SELECT * FROM Users WHERE Id = id
            return user;
        }


        public int GetUserIdById(int id)
        {
            var user = UserDBNolongerUsed.Users.Where(x => x.Id == id).FirstOrDefault(); // SELECT * FROM Users WHERE Id = id
            return user?.Id ?? -1;
        }



        public bool IsUserExists(int id)
        {
            int numberOfUsers = UserDBNolongerUsed.Users.Where(x => x.Id == id).Count(); //SELECT COUNT(*) FROM Users WHERE Id = id
            bool hasusers = numberOfUsers > 0;
            return hasusers;

            //Could also do this 
            // return User.Users.Any(x => x.Id == id);
        }
    }
}
