using DemoComsoleApplication.DataAccess.DataBaseSim;
using DemoConsoleProject.Presentation.DataBaseSim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComsoleApplication.DataAccess.DAL
{
    public abstract class BaseRepository<T> where T : BaseEntity //Constraint on the Generic  //ADD MORE RESTRICTIONS 
    {
        //4 -CREATE READ UPDATE DELETE 

        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _context = new AppDbContext();
            _dbSet = _context.Set<T>();
            
             
        }


        public T Create(T entity)
        {
            using (var context = new AppDbContext())
            {
                _dbSet.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        //public   abstract T Update(T entity);

        //4 methods 

    }
}


/*
 * 
 * public -> it is accessible everywhere 
 * private -> only withing the same class
 * internal -> only withing the same assembly
 * protected -> Its only accesible to Inheriting mebers 
 * abstract -> any class marked abastract can only be used as a base class , it can never be instantiated so no new BaseCalss() 
 * static -> static class cannot be instatiated , it can have only static members , and ae called using the class name directly
 *         -> sattic members in non static class , the members are meta , i.e.same is shared for every object create  
 *         
 * interfaces -> interface is a contract that is used to define a set of methods that a class must implement , what the implemeting classes must have 
 */

