using DemoComsoleApplication.DataAccess.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Presentation.DataBaseSim
{
    //entity model 
    public class User : BaseEntity
    {
        public string Name { get; set; }
        
    }

    public class UserDBNolongerUsed
    {
        public static List<User> Users = new List<User>();  //Will not be going to store it here 
    }
}
