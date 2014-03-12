using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public ActionResult Search( string name)
        {
            throw new Exception("Something wrong");
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

    }
}
