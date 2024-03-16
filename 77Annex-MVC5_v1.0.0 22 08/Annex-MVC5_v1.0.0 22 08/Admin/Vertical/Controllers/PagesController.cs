using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vertical.Controllers
{
    public class PagesController : Controller
    {
        [ActionName("pages-404")]
        public ActionResult pages404()
        {
            return View();
        }
        [ActionName("pages-500")]
        public ActionResult pages500()
        {
            return View();
        }
        [ActionName("pages-blank")]
        public ActionResult pagesblank()
        {
            return View();
        }
        [ActionName("pages-lock-screen")]
        public ActionResult pageslockscreen()
        {
            return View();
        }
        [ActionName("pages-login")]
        public ActionResult pageslogin()
        {
            return View();
        }
        [ActionName("pages-recoverpw")]
        public ActionResult pagesrecoverpw()
        {
            return View();
        }
        [ActionName("pages-register")]
        public ActionResult pagesregister()
        {
            return View();
        }
    }
}