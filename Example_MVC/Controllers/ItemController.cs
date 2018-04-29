using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example_MVC.Models;

namespace Example_MVC.Controllers
{
    public class ItemController : Controller
    {
        // 1. *********** Display All Item List in Index Page ***********
        public ActionResult Index()
        {
            ViewBag.ItemList = "Nutkonon Shop Item List Page";
            ItemDBHandler IHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }
        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel iList)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ItemDBHandler ItemHandler = new ItemDBHandler();
                    if (ItemHandler.InsertItem(iList))
                    {
                        ViewBag.Message = "Item Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch { return View(); }
        }

        // 3. *********** Update Item Details ***********
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(int id, ItemModel iList)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        // 4. *********** Delete Item Details ***********
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        public ActionResult Details(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }

    }
}