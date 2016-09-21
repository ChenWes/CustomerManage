using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;

namespace CustomerManage.Common
{
    /// <summary>
    /// 用户提示公共类
    /// </summary>
    public class UserNotifyBase : IUserNotifySubject
    {
        private ArrayList observers;


        private string notifyType;
        private int notifyCount;

        public UserNotifyBase()
        {
            observers = new ArrayList();
        }

        public void registerObserver(IUserNotifyObserver o)
        {
            //注册，如不存在则加入
            int i = observers.IndexOf(o);
            if (i < 0)
            {
                observers.Add(o);
            }
        }

        public void removeObserver(IUserNotifyObserver o)
        {
            //移除，如存在则移除
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void notifyObservers()
        {
            //for (int i = 0; i < observers.Count; i++)
            //{
            //    IUserNotifyObserver observer = (IUserNotifyObserver)observers[i];
            //    observer.Update(notifyType, notifyCount);
            //}

            //注册的观察者逐个调用通知方法
            foreach (IUserNotifyObserver Observer in observers)
            {
                Observer.Update(notifyType,notifyCount);
            }

        }

        public void SettingNotify(string pi_NotifyType, int pi_NotifyCount)
        {
            this.notifyType = pi_NotifyType;
            this.notifyCount = pi_NotifyCount;

            notifyObservers();
        }
    }
}