using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication46.Models;

namespace WebApplication46.Controllers
{
    public class HomeController : Controller
    {
        private FnolEntities8 db = new FnolEntities8();
        private FnolEntities11 involed_db=new FnolEntities11();
        private FnolEntities6 Damage_db = new FnolEntities6();
        public ActionResult Index()
        {
            var allUserCount = db.Personal_Info.Count();
            ViewBag.TotalUsersCount = allUserCount;
            var allInvoledPartyCount = involed_db.Involed_Party.Count();
            ViewBag.TotalInvoledPartyCount=allInvoledPartyCount;
            var allDamagedetailCount=Damage_db.Damage_Details.Count();
            ViewBag.TotalDamageCount=allDamagedetailCount;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            
            return RedirectToAction("Create", "Personal_Info");
        }

    }
}