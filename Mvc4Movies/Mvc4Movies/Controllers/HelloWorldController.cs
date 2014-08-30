
using Mvc4Movies.Models.Checkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        private Checker checker;

        //
        // GET: /Hello/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public ActionResult ValidatePassword(string password)
        {
            NullChecker chk = new NullChecker(password);            
            
            return View();
        }
    }
}
