using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]  // Can put Authorize here to make it controller level
    [LogAttribute]
    public class CuisineController : Controller
    {

        //[Authorize] // Can put Authorize here to make it method/ActionResult level
        public ActionResult Search(string name = "French")
        {
            throw new Exception("Something bad happened!");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }


    }
}
