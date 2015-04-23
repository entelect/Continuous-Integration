using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleWebApp.ViewModels;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = ConfigurationManager.AppSettings["message"];
            var release = ConfigurationManager.AppSettings["OcotpusReleaseVersion"];
            return View(new MessageView()
                            {
                                Message = message + "- Release " + release
                            });
        }

    }
}
