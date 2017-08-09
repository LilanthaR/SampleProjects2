using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Reflection;
using System.Text;

using IJSE.POS.Service.WebAPI.DynamicCode;
    
namespace IJSE.POS.Service.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Dynamic()
        {
            ViewBag.Title = "Dyanamic";     

            return View();
        }
    }
}
