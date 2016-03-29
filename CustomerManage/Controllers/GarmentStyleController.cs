using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using System.Text;
using System.IO;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace CustomerManage.Controllers
{
    public class GarmentStyleController : Controller
    {
        //
        // GET: /GarmentType/
        
        public ActionResult GetById()
        {
            CustomerManage.Hubs.ChatHub.Send("System", DateTime.Now.ToString() + " Run GetByID");

            return View(ViewBag);  
        }

        public ActionResult List()
        {
            return View();
        }

        public JsonResult GetDepartment(int limit, int offset)
        {
            var lstRes = new List<CustomerManage.Models.Dept>();
            for (var i = 0; i < 50; i++)
            {
                var oModel = new CustomerManage.Models.Dept();
                oModel.ID = Guid.NewGuid().ToString();
                oModel.Name = "销售部[" + i.ToString() + "]";
                oModel.Level = i.ToString();
                oModel.Desc = "销售部[" + i.ToString() + "]描述信息";
                lstRes.Add(oModel);
            }

            var total = lstRes.Count;
            var rows = lstRes.Skip(offset).Take(limit).ToList();
            return Json(new { total = total, rows = rows }, JsonRequestBehavior.AllowGet);
        }

        public static string Serializer(Type type, object obj)
        {
            MemoryStream Stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(type);
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();

            sr.Dispose();
            Stream.Dispose();

            return str;
        }
	}
}