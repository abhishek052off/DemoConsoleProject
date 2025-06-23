using DemoComsoleApplication.DataAccess.DataBaseSim;
using DemoConsoleProject.Presentation.DAL;
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComsoleApplication.DataAccess.DAL
{
    public class UserRepository : IUserDataAccess
    {
        public int CreateUser(string name)
        {
            using (var dbContext = new AppDbContext())
            {
                var user = new User()
                {
                    Name = name,
                };

                dbContext.Users.Add(user);

                dbContext.SaveChanges(); //Exceptions 

                return user.Id;
            }
            ;
        }

        public List<User> GetAllUsers()
        {
            using(var dbContext = new AppDbContext())
            {
                var users = dbContext.Users;
                return users.ToList(); // Count() , individually iterate , FirstOrDefault() , First()
            }
        }

        public User GetUserById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var users = dbContext.Users.Where(x => x.Id == id);
                return users.FirstOrDefault();  
            }
        }

        public int GetUserIdById(int id)
        {
             return id;
        }

        public bool IsUserExists(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var users = dbContext.Users.Where(x => x.Id == id);
                return users.Any();
            }
        }

        public int UpdateUser(string name, int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var user = dbContext.Users.Where(x => x.Id == id).FirstOrDefault();
                
                if (user == null)
                {
                    return -1; //throw Exception 
                }

                user.Name = name;
                dbContext.SaveChanges();
                return user.Id;
            }
        }
    }
}
