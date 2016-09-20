using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            getDescription = "Dark Roast Coffee";
        }                

        public override double cost()
        {
            return 1.66;
        }
    }
}