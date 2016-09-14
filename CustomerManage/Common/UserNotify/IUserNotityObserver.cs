using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    /// <summary>
    /// 观察者通知方法
    /// </summary>
    public interface IUserNotifyObserver
    {
        void Update(string pi_notifyType,int pi_notityCount);
    }
}