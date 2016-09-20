using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string getDescription();
    }
}