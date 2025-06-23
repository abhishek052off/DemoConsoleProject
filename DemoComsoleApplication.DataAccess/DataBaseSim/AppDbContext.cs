using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComsoleApplication.DataAccess.DataBaseSim
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=SampleDbContext")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
