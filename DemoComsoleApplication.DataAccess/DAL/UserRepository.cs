using DemoComsoleApplication.DataAccess.DataBaseSim;
using DemoConsoleProject.Presentation.DAL;
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DemoComsoleApplication.DataAccess.DAL
{
    public class UserRepository : BaseRepository<User>, IUserDataAccess // CRUD
    {
        
 

        public int CreateUser(string name)
        {

            var user = new User()
            {
                Name = name,
            };

            _context.Users.Add(user);

            _context.SaveChanges(); //Exceptions 

            return user.Id;
         
        }

        public List<User> GetAllUsers()
        {
            var users = _context.Users;
            return users.ToList(); // Count() , individually iterate , FirstOrDefault() , First()
        }

        public User GetUserById(int id)
        {
            var users = _context.Users.Where(x => x.Id == id);
            return users.FirstOrDefault();
        }

        public int GetUserIdById(int id)
        {
             return id;
        }

        public bool IsUserExists(int id)
        {
            var users = _context.Users.Where(x => x.Id == id);
            return users.Any();
        }

        public int UpdateUser(string name, int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null)
            {
                return -1; //throw Exception 
            }

            user.Name = name;
            _context.SaveChanges();
            return user.Id;
        }

        //---FRESH START ---

      

    }


    //----------DEMO PURPOSE ------------DOT DOING ANYTHING 

    //public class DemoClass
    //{
    //    public int ID { get; set; }
    //}

    //public class DemoRepository : BaseRepository<DemoClass>
    //{

    //}

    //


}
