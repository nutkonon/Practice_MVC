using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_MVC.Controllers
{
    public class ItemController : Controller
    {
        //GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Nutkonon Shop Item List Page";
            return View();

        }

        //public EmptyResult Index()
        //{
        //    ViewBag.ItemList = "Nutkonon Shop Item List Page";
        //    return new EmptyResult();
        //}

        //public JsonResult Index()
        //{
        //    Itemlist list = new Itemlist()
        //    {
        //        ID = "id1",
        //        Name = "Nutkonon",
        //        Mobile = "0999999999"
        //    };
        //    return Json(emp, JsonRequestBehavior.AllowGet);
        //}

        public class Itemlist
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
        }

    }
}