using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription + ", Mocha";
        }

        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }
}