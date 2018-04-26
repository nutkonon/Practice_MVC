using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_MVC.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Nutkonon Shop Item List Page";
            return View();
        }
    }
}