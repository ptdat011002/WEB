using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Layout()
        {
            ViewBag.Message = "D15CNPM5";
            string[] MonHoc = new string[] { "Toán", "Văn", "Anh" };
            ViewBag.MonHoc = MonHoc;
            return View();
        }
    }
}