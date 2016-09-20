using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public abstract class Beverage
    {
        private string l_description = "Unknown Beverage";

        public string getDescription
        {
            get { return l_description; }
            set { l_description = value; }
        }        

        public abstract double cost();
    }
}