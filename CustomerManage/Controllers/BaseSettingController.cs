using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManage.Controllers
{
    public class BaseSettingController : Controller
    {
        //
        // GET: /BaseSetting/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserAccount()
        {
            return View();
        }

        public ActionResult UserRole()
        {
            return View();
        }
	}
}