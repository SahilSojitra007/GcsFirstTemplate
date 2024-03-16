using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Horizontal.Controllers
{
    public class AdvancedController : Controller
    {
        [ActionName("advanced-highlight")]
        public ActionResult advancedhighlight()
        {
            return View();
        }

        [ActionName("advanced-rating")]
        public ActionResult advancedrating()
        {
            return View();
        }

        [ActionName("advanced-alertify")]
        public ActionResult advancedalertify()
        {
            return View();
        }
        [ActionName("advanced-rangeslider")]
        public ActionResult advancedrangeslider()
        {
            return View();
        }
    }
}