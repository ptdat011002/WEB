using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if(username == "admin" && password == "123")
            {
                // Ghi nhận trạng thái đăng nhập của người dùng trên session
                Session["User"] = username;
                // Đăng nhập thành công và điều hướng sang trang SinhVien/List
                return RedirectToAction("List", "SinhVien");
            }
            ViewBag.Message = "ĐĂNG NHẬP THẤT BẠI";
            return View();
        }
    }
}