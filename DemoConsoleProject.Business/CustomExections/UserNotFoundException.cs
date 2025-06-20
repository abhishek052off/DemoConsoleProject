using DemoConsoleProject.Business.CustomExections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Business.CustomExections
{
    public class UserNotFoundException : Exception
    {
        public const string message = "User not found";

        public int UserId { get; set; }
        public UserNotFoundException(int userId) : base(message)
        {
            UserId = userId;
        }
    }
}

//new UserNotFoundException("User not found");