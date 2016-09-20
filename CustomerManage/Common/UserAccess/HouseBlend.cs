using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            getDescription = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}