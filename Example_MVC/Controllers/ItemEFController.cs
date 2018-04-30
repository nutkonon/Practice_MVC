using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Example_MVC.Models;

namespace Example_MVC.Controllers
{
    public class ItemEFController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: ItemEF
        public ActionResult Index()
        {
            return View(db.ItemLists.ToList());
        }

        // GET: ItemEF/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // GET: ItemEF/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemEF/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Category,Price")] ItemList itemList)
        {
            if (ModelState.IsValid)
            {
                db.ItemLists.Add(itemList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemList);
        }

        // GET: ItemEF/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // POST: ItemEF/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Category,Price")] ItemList itemList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemList);
        }

        // GET: ItemEF/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // POST: ItemEF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemList itemList = db.ItemLists.Find(id);
            db.ItemLists.Remove(itemList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
