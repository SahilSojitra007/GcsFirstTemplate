using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AOP = DataLibrary.SqlClientOperation;

namespace CryptoDash.Controllers
{
    public class HomeController : Controller
    {
        String Conn_String  = System.Configuration.ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult exchange()
        {
            return View();
        }
        public ActionResult mywallet()
        {
            return View();
        }
        public ActionResult calendar()
        {
            return View();
        }
        public ActionResult news()
        {
            return View();
        }
        public ActionResult ico()
        {
            return View();
        }
        public ActionResult setting()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult logout()
        {
            return View();
        }
        [ActionName("pages-blank")]
        public ActionResult pagesblank()
        {
            return View();
        }
    }
}