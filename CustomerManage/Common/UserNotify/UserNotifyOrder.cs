using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    public class UserNotifyOrder : IUserNotifyObserver, IUserNotifyDisplay
    {
        private string l_orderType;
        private int l_orderCount;
        private IUserNotifySubject userData;

        public string mc_GetNotifyMessagel;

        public UserNotifyOrder(IUserNotifySubject userData)
            : base()
        {
            this.userData = userData;
            userData.registerObserver(this);
        }

        public void Update(string pi_notifyType, int pi_notityCount)
        {
            this.l_orderType = pi_notifyType;
            this.l_orderCount = pi_notityCount;

            Display();
        }

        public void Display()
        {
            mc_GetNotifyMessagel = "hi, you have " + l_orderType + " type " + l_orderCount + " order,";
        }
    }
}