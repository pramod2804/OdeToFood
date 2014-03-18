using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index( string searchTerm = null)
        {
            var model = from r in _db.Restaurants
                        orderby r.Name descending
                        select r;
            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Pramod";
            model.Location = "Tempe,AZ";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
