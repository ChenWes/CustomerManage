using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            getDescription = "Espresso";
        }        

        public override double cost()
        {
            return 1.99;
        }
    }
}