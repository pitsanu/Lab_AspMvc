using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Hosting;

namespace AspLifeCycle.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //ApplicationManager m = ApplicationManager.GetApplicationManager();
            //ApplicationInfo[] x = m.GetRunningApplications();

            HttpRequestBase x = Request;
            ViewBag.UserName = User.Identity.Name;
            return View(x);
        }

    }
}
