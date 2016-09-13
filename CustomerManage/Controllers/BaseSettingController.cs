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

        public List<CustomerManage.Models.Dept> GetDept()
        {
            List<CustomerManage.Models.Dept> DeptList = new List<Models.Dept>();

            for (int i = 0; i < 50; i++)
            {
                DeptList.Add(new Models.Dept() { ID = i.ToString(), Level = i.ToString(), Name = "Wes" + i.ToString(), Desc = "Customer" });
            }

            return DeptList;
        }
	}
}