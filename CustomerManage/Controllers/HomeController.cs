using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CustomerManage.Hubs;

namespace CustomerManage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            CustomerManage.Hubs.ChatHub.Send("System", DateTime.Now.ToString() + " Run GetByID");
            CustomerManage.Hubs.SystemMessageHub.Send("System", DateTime.Now.ToShortDateString(), "Info", "System On Line");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }


    }
}