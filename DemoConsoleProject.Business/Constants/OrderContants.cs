using DemoConsoleProject.Business.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleProject.Business.Constants
{
    public static class OrderTypesNames
    {
        public const string OnlineOrder = "Online";
    }

    //
    public enum OrderTypes
    {
        Online = 1,
        Offline = 2
    }

    //orderType==1 

    //orderType == OrderTypes.Online
}


