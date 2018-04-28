using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["FirstValue"] = "Hello World";
            return View();
        }

        public ActionResult About()
        {
            if (TempData["FirstValue"] != null)
            {
                TempData.Keep();
                return RedirectToAction("Contact");
            }
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            if (TempData["FirstValue"] != null)
            {
                ViewBag.MSG1 = TempData["FirstValue"].ToString();
            }
            return View();
        }

        public ActionResult Enquiry()
        {
            return View();
        }

        public ActionResult Purchase()
        {
            return View();
        }

        public ActionResult DarkLayoutPage()
        {
            ViewBag.Title = "Nutkonon Layout";
            return View();
        }
    }
}