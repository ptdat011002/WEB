using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            List<dynamic> lst = new List<dynamic>
            {
                new
                {
                    ID = 1,
                    Name = "D15CNPM5"
                },
                new
                {
                    ID = 2,
                    Name = "D15CNPM4"
                },
                new
                {
                    ID = 3,
                    Name = "D15CNPM3"
                },
                new
                {
                    ID = 4,
                    Name = "D15CNPM2"
                },
                new
                {
                    ID = 5,
                    Name = "D15CNPM1"
                }
            };
                // ID: ValueNumber
                // Name: DisplayNumber
                ViewBag.Classes = new SelectList(lst,"ID","Name");

            
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Detail1()
        {
            ViewBag.Id = "123";
            ViewBag.PassWord = "123456";
            ViewBag.FullName = "Pham Tri Dat";
            ViewBag.Gender = "Nam";
            ViewBag.Birthday = "01/10/2002";
            ViewBag.Notes = "Test";
            return View();
        }
        public ActionResult Detail2()
        {
            Models.DTO.SinhVien obj = new Models.DTO.SinhVien()
            {
                Id = "321",
                PassWord = "654321",
                FullName = "Dat Tri Pham",
                Gender = true,
                Birthday = new DateTime(2002, 01, 10),
                Notes = "Test",
            };
            return View(obj);
        }
        public ActionResult List()
        {
            // Kiểm tra xem phiên hiện tại đã đăng nhập hay chưa
            string User = (string)Session["User"];
            if(User == null || User == "")
            {
                return RedirectToAction("Index", "Login");
            }
            List<Models.DTO.SinhVien> lst = new List<Models.DTO.SinhVien>()
            {
                new Models.DTO.SinhVien()
                {
                    Id = "456",
                    PassWord = "654321",
                    FullName = "Dat Tri Pham",
                    Gender = true,
                    Birthday = new DateTime(2002, 01, 10),
                    Notes = "Test",
                },
                new Models.DTO.SinhVien()
                {
                    Id = "123",
                    PassWord = "123456",
                    FullName = "Pham Tri Dat",
                    Gender = true,
                    Birthday = new DateTime(2002, 10, 01),
                    Notes = "Test",
                },
            };          
             return View(lst);
        }
    }
}