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
    public class Damage_DetailsController : Controller
    {
        private FnolEntities6 db = new FnolEntities6();

        // GET: Damage_Details
        public ActionResult Index()
        {
            return View(db.Damage_Details.ToList());
        }

        // GET: Damage_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Damage_Details damage_Details = db.Damage_Details.Find(id);
            if (damage_Details == null)
            {
                return HttpNotFound();
            }
            return View(damage_Details);
        }

        // GET: Damage_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Damage_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Staring,HOOD,Front_Bumper,Front_Passenger_side_fender,Passenger_door,Rear_assenger_side_quarter_panel,Rear_bumper,Rear_Trunk,Driver_door,Undercarriage,Policy_Number")] Damage_Details damage_Details)
        {
            if (ModelState.IsValid)
            {
                db.Damage_Details.Add(damage_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(damage_Details);
        }

        // GET: Damage_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Damage_Details damage_Details = db.Damage_Details.Find(id);
            if (damage_Details == null)
            {
                return HttpNotFound();
            }
            return View(damage_Details);
        }

        // POST: Damage_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Staring,HOOD,Front_Bumper,Front_Passenger_side_fender,Passenger_door,Rear_assenger_side_quarter_panel,Rear_bumper,Rear_Trunk,Driver_door,Undercarriage,Policy_Number")] Damage_Details damage_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(damage_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(damage_Details);
        }

        // GET: Damage_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Damage_Details damage_Details = db.Damage_Details.Find(id);
            if (damage_Details == null)
            {
                return HttpNotFound();
            }
            return View(damage_Details);
        }

        // POST: Damage_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Damage_Details damage_Details = db.Damage_Details.Find(id);
            db.Damage_Details.Remove(damage_Details);
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
