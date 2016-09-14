using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManage.Common
{
    /// <summary>
    /// 用户通知主题接口
    /// </summary>
    public interface IUserNotifySubject
    {
        void registerObserver(IUserNotifyObserver o);   //注册观察者模式
        void removeObserver(IUserNotifyObserver o);     //移除观察者模式
        void notifyObservers();                         //调用通知方法

        void SettingNotify(string pi_NotifyType, int pi_NotifyCount);
    }
}