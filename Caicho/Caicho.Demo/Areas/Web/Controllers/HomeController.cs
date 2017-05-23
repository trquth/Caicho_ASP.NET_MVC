using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caicho.Demo.Areas.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Web/Home
        public ActionResult Index()
        {
            bool test = CheckFileExitOnServer("~/build", "index.html");
            if (test)
            {
                return new FilePathResult("~/build/index.html", "text/html");
            }
            //Change by another page such as Error page
            return new FilePathResult("~/build/index.html", "text/html");
            //return View();
        }

        private bool CheckFileExitOnServer(string path, string fileName)
        {
            bool exists = false;
            string relativePath = String.Format("{0}/{1}", path, fileName);
            string absolutePath = HttpContext.Server.MapPath(relativePath);
            if (System.IO.File.Exists(absolutePath))
            {
                exists = true;
            }
            return exists;
        }
    }
}