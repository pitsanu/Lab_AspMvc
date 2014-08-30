using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Movies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /* Test Action */
        public string TestReturnString()
        {
            return "Hello World";
        }

        public JsonResult TestReturnJson()        
        {
            IList<double> priceList = new List<double>() { 2.05, 3.75 };
            var obj = new { Word = "HelloWorld", Name = "Pitsanu", LastName = "Tongprasin", Array = priceList };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult TestGotoGoogle()
        {
            return new RedirectResult("http://www.google.com");
        }

        public FileResult TestReturnFileResult()
        {

            //return new FilePathResult(Server.MapPath(Url.Content("~/Content/test.jpg")), "image/jpeg");          
            
            //FilePathResult obj= new FilePathResult(Server.MapPath(Url.Content("~/Content/test.xlsx")), "application/vnd.ms-excel");
            //obj.FileDownloadName = "my friendly name.xlsx";
            //return obj;

            string filename = Server.MapPath(Url.Content(string.Format("~/Media/{0}", "test.xlsx")));            
            string mimetype = MimeMapping.GetMimeMapping(filename);
            
            FilePathResult rtn= new FilePathResult(filename, mimetype);
            rtn.FileDownloadName = string.Format("test_{0}.xlsx", DateTime.Now);
            return rtn;
        }
    }
}
