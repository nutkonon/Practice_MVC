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

        public ActionResult TestForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormWeakly(int txtId, string txtName, string txtCategory, string txtPrice, string chkAddon)
        {
            ViewBag.Id = txtId;
            ViewBag.Name = txtName;
            ViewBag.Category = txtCategory;
            ViewBag.Price = txtPrice;
            if (chkAddon != null)
                ViewBag.Addon = "Selected";
            else
                ViewBag.Addon = "Not Selected";
            return View("TestForm");
        }

        [HttpPost]
        public ActionResult FormStrongly(Models.ItemModel it)
        {
            ViewBag.Id = it.ID;
            ViewBag.Name = it.Name;
            ViewBag.Category = it.Category;
            ViewBag.Price = it.Price;
            return View("TestForm");
        }

        [HttpPost]
        public ActionResult FormStronglyAJ(Models.ItemModel it)
        {
            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("ID: " + it.ID + "<br />");
                sb.Append("Name: " + it.Name + "<br />");
                sb.Append("Category: " + it.Category + "<br />");
                sb.Append("Price: " + it.Price + "<br />");
                return Content(sb.ToString());
            }
            else
            {
                return View("TestForm");
            }
        }

        [HttpPost]
        public ActionResult FormPureHTML(Models.ItemModel it)
        {
            string value = "ID: " + Convert.ToString(it.ID)
                + "<br />Name: " + it.Name
                + "<br />Category: " + Convert.ToString(it.Category)
                + "<br />Price: " + Convert.ToString(it.Price);

            string s = "$('#output').html('" + value + "');";
            return JavaScript(s);
        }

        [HttpPost]
        public ActionResult FormCollec(FormCollection fc)
        {
            ViewBag.Id = fc["ID"];
            ViewBag.Name = fc["Name"];
            ViewBag.Category = fc["Category"];
            ViewBag.Price = fc["Price"];
            return View("TestForm");
        }

        public ActionResult TestValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidationItem(Models.ItemModel it)
        {
            if (it.ID.ToString() == "")
                ModelState.AddModelError("ID", "ID Required");
            if (string.IsNullOrEmpty(it.Name))
                ModelState.AddModelError("Name", "Name Required");
            if (string.IsNullOrEmpty(it.Category))
                ModelState.AddModelError("Category", "Category Required");
            if(it.Price.ToString() == "")
                ModelState.AddModelError("Price", "Price Required");
            if (ModelState.IsValid)
            {
                ViewBag.ID = it.ID;
                ViewBag.Name = it.Name;
                ViewBag.Category = it.Category;
                ViewBag.Price = it.Price;
                return View("TestValidation");
            }
            else
            {
                ViewBag.ID = "No Data";
                ViewBag.Name = "No Data";
                ViewBag.Category = "No Data";
                ViewBag.Price = "No Data";
                return View("TestValidation");
            }
            
        }
    }
}