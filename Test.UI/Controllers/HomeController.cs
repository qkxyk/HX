using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Model;
using Test.Service;
using Newtonsoft.Json;

namespace Test.UI.Controllers
{
    public class HomeController : Controller
    {
        private IService<DeviceModel> _device;
        private IService<DeviceTypeModel> _deviceType;
        public HomeController(IService<DeviceModel> device, IService<DeviceTypeModel> deviceType)
        {
            _device = device;
            _deviceType = deviceType;
        }

        public ActionResult AddType(string name)
        {
            DeviceTypeModel dtm = new DeviceTypeModel() { TypeName = name };
            _deviceType.Add(dtm);
           // return Json(dtm);
            string str = JsonConvert.SerializeObject(dtm);
            return Content(str);
            //IEnumerable<DeviceTypeModel> li = _deviceType.Get();

            //return Json(li, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteType(int id)
        {
            DeviceTypeModel dtm = new DeviceTypeModel() { Id = id };
            _deviceType.Delete(dtm);
            return null;
        }
        public ActionResult Index()
        {
            IEnumerable<DeviceModel> list = _device.Get();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}