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
    public class Personal_InfoController : Controller
    {
        private FnolEntities8 db = new FnolEntities8();

        // GET: Personal_Info
        public ActionResult Index(string option, string search)
        {   
            var data= db.Personal_Info.Count();
            TempData["totaluser"] = data;
            TempData["message"] = "hellowsir";
            if (option == "FIrstName")
            {
                return View(db.Personal_Info.Where(x => x.First_Name == search || search == null).ToList());
            }
            else if (option == "Gender")
            {
                return View(db.Personal_Info.Where(x => x.Last_Name == search || search == null).ToList());
            }
            else
            {
                return View(db.Personal_Info.Where(x => x.First_Name.StartsWith(search) || search == null).ToList());
            }

        }

        // GET: Personal_Info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Info personal_Info = db.Personal_Info.Find(id);
            if (personal_Info == null)
            {
                return HttpNotFound();
            }
            return View(personal_Info);
        }

        // GET: Personal_Info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personal_Info/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "First_Name,Last_Name,Policy_Type,Policy_Number,Phone_Number")] Personal_Info personal_Info)
        {
            if (ModelState.IsValid)
            {
                db.Personal_Info.Add(personal_Info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personal_Info);
        }

        // GET: Personal_Info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Info personal_Info = db.Personal_Info.Find(id);
            if (personal_Info == null)
            {
                return HttpNotFound();
            }
            return View(personal_Info);
        }

        // POST: Personal_Info/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "First_Name,Last_Name,Policy_Type,Policy_Number,Phone_Number")] Personal_Info personal_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal_Info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personal_Info);
        }

        // GET: Personal_Info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Info personal_Info = db.Personal_Info.Find(id);
            if (personal_Info == null)
            {
                return HttpNotFound();
            }
            return View(personal_Info);
        }

        // POST: Personal_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personal_Info personal_Info = db.Personal_Info.Find(id);
            db.Personal_Info.Remove(personal_Info);
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
