using DemoConsoleProject.Business.Service;
using DemoConsoleProject.Presentation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Presentation
{

  //Internal is accesible only in the same DLL ,
  public class Program
  {
    public static void PreviouslyMain()
    {
      Console.WriteLine("Hello World!");

      //Value types 
      int age = 20;
      bool isAlive = true;

      //ref types , lives in heap memory and its , refrence will be in stack  
      string name = "Abhishek Mishra";

      Person personAlpha = new Person(); //Allocated the mem in heap 
      personAlpha.Name = name;
      personAlpha.Age = age;
      personAlpha.GetName();

      // personAlpha.instance++; //not assoc with the object 

      var person1 = new Person();
      Console.WriteLine("instances of person " + Person.instances);

      //Program.AddAges(personAlpha , person1 );
      int sum = AddAges(personAlpha, person1);

      Console.WriteLine(sum);

      //PBV

      int value1 = 10;
      int value2 = 20;
      PassByValueEx(value1, value2); //Copying the value and passing it on 

      Console.WriteLine("From outside the method " + value1 + " " + value2); //Value doesnt change if re assigned 

      personAlpha.Age = 30;
      person1.Age = 40;

      passByRef(personAlpha, person1); // Its not copying , its passing the reference or address 

      Console.WriteLine("From outside the method " + personAlpha.Age + " " + person1.Age);

      //since int , float , double etc are value types , they are passed by value by default 

      //Objects are passed by reference 

      passByRefUsingRef(ref value1, ref value2);
      Console.WriteLine("From outside the method " + value1 + " " + value2); //Value changes because its passed by refernce 

      Console.ReadKey(); //\n

    }

    public static int AddAges(Person person1, Person person2)
    {
      return person1.Age + person2.Age;
    }

    public static void PassByValueEx(int num1, int num2)
    {
      num1 = 1000;
      num2 = 2000;

      Console.WriteLine("From inside the method " + num1 + " " + num2);
    }

    public static void passByRef(Person p1, Person p2)
    {
      p1.Age = 99;
      p2.Age = 100;
      Console.WriteLine("From inside the method " + p1.Age + " " + p2.Age);
    }

    public static void passByRefUsingRef(ref int num1, ref int num2)
    {
      num1 = 1000;
      num2 = 2000;

      Console.WriteLine("From inside the method " + num1 + " " + num2);
    }

    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine(" Select Operation : \n 1.Create User \n 2.Get All Users \n 3.Create Orders \n 4.Update User \n");

        string input = Console.ReadLine();
        int userChoice = Convert.ToInt32(input);

        switch (userChoice)
        {
          case 1:
            CreateUser();
            break;
          case 2:
            GetAllUsers();
            break;
          case 3:
            CreateOrder();
            break;
          case 4:
            UpdateUser();
            break;
          default:
            Console.WriteLine("Invalid Input");
            break;
        }
      }

      //User 

      //Product 

      //Order
    }

    private static void GetAllUsers()
    {
      var userService = new UserService();

      var users = userService.GetAllUsers();

      foreach (var user in users)
      {
        Console.WriteLine("User Id : " + user.Id + " Name : " + user.Name);
      }
    }

    static void CreateUser()
    {
      Console.WriteLine("Enter Name");
      string name = Console.ReadLine();

      var userService = new UserService();

      int id = userService.CreateUser(name);

      Console.WriteLine("User Created Successfully " + id);
    }

    static void CreateOrder()
    {
      Console.WriteLine("Enter User Id :");
      int userId = Convert.ToInt32(Console.ReadLine());
      var userService = new UserService();
      int presentUserId = userService.GetUserById(userId);
      if (presentUserId == -1)
      {
        CreateUser();
      }
      var orderService = new OrderService();
      int orderId = orderService.CreateOrder(userId);
      Console.WriteLine("Order Created Successfully " + orderId);
    }

    static void UpdateUser()
    {
      Console.WriteLine("Enter User Id :");
      int id = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Name to Update :");
      string name = Console.ReadLine();

      var userService = new UserService();
      int userId = userService.GetUserById(id);
      if (userId == -1)
      {
        Console.WriteLine("User id Not Found");
      }
      else
      {
        userService.UpdateUser(name, id);
        Console.WriteLine("User Updated Successfully " + id);
      }
    }
  }

  public class Person //capsule , 
  {
    public static int instances = 0;

    //About the personAlpha
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
      instances++;
    }

    //Capabilkities 
    public void GetName()
    {
      Console.WriteLine($"Name: {Name}");
    }


  }
}
