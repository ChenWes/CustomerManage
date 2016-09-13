using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CustomerManage.Hubs
{
    public class SystemMessageHub : Hub
    {
        static IHubContext signalRHub;

        /// <summary>
        /// 系统提示广播类
        /// </summary>
        /// <param name="pi_messageSender"></param>
        /// <param name="pi_messageDateTime"></param>
        /// <param name="pi_messageType"></param>
        /// <param name="pi_messageContent"></param>
        public static void Send(string pi_messageSender, string pi_messageDateTime, string pi_messageType, string pi_messageContent)
        {
            if (signalRHub == null)
            {
                signalRHub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            }
            if (signalRHub != null)
            {
                signalRHub.Clients.All.addNewMessage(pi_messageSender, pi_messageDateTime, pi_messageType, pi_messageContent);
            }
        }
    }
}