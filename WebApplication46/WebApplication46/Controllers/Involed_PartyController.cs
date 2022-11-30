using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication46.Models;

namespace WebApplication46.Controllers
{
    public class Involed_PartyController : Controller
    {
        private FnolEntities11 db = new FnolEntities11();

        // GET: Involed_Party
        public ActionResult Index()
        {
            return View(db.Involed_Party.ToList());
        }

        // GET: Involed_Party/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Involed_Party involed_Party = db.Involed_Party.Find(id);
            if (involed_Party == null)
            {
                return HttpNotFound();
            }
            return View(involed_Party);
        }

        // GET: Involed_Party/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Involed_Party/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Frist_Name,Last_Name,Insurance_Provider,Year,Model,Policy_Number,Phone_Number")] Involed_Party involed_Party)
        {
            if (ModelState.IsValid)
            {
                db.Involed_Party.Add(involed_Party);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(involed_Party);
        }

        // GET: Involed_Party/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Involed_Party involed_Party = db.Involed_Party.Find(id);
            if (involed_Party == null)
            {
                return HttpNotFound();
            }
            return View(involed_Party);
        }

        // POST: Involed_Party/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Frist_Name,Last_Name,Insurance_Provider,Year,Model,Policy_Number,Phone_Number")] Involed_Party involed_Party)
        {
            if (ModelState.IsValid)
            {
                db.Entry(involed_Party).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(involed_Party);
        }

        // GET: Involed_Party/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Involed_Party involed_Party = db.Involed_Party.Find(id);
            if (involed_Party == null)
            {
                return HttpNotFound();
            }
            return View(involed_Party);
        }
        // POST: Involed_Party/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Involed_Party involed_Party = db.Involed_Party.Find(id);
            db.Involed_Party.Remove(involed_Party);
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
