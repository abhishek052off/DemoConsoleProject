using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComsoleApplication.DataAccess.DataBaseSim
{
    public abstract class BaseEntity //Base entity does nothing but only acts as a type restraint for base reposoitoruy 
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    ///
    //{ id , creat4ed at , updated at }
    
}
