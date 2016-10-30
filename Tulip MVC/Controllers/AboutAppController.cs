using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Net.Tulip.Web.MVC.Models;

namespace Net.Tulip.Web.MVC.Controllers
{
    public class AboutAppController : Controller
    {
        // GET: AboutApp
        public ActionResult Index()
        {
            AboutApp aAboutApp = new AboutApp()
            {
                MVCVersion = typeof(Controller).Assembly.GetName().Version.ToString(),
                DotNetVersion ="4.6.1",
                VSVersion="2015 Enterprise"
            };

            return View(aAboutApp);
        }
    }
}