using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        
        [HttpPost]
        public ActionResult Search(string name = "French")
        {
            var message = Server.HtmlEncode(name);
            // Example redirects
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Jim" }, JsonRequestBehavior.AllowGet);
            return Content(message);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("Search!");
        }

    }
}
