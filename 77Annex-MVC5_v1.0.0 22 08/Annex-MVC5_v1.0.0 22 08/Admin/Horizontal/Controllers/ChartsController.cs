using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Horizontal.Controllers
{
    public class ChartsController : Controller
    {
        [ActionName("charts-morris")]
        public ActionResult chartsmorris()
        {
            return View();
        }

        [ActionName("charts-chartist")]
        public ActionResult chartschartist()
        {
            return View();
        }
        [ActionName("charts-chartjs")]
        public ActionResult chartschartjs()
        {
            return View();
        }
        [ActionName("charts-flot")]
        public ActionResult chartsflot()
        {
            return View();
        }
        [ActionName("charts-c3")]
        public ActionResult chartsc3()
        {
            return View();
        }
        [ActionName("charts-other")]
        public ActionResult chartsother()
        {
            return View();
        }
    }
}