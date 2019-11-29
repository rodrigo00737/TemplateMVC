using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateGentelella.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            string userName = string.Empty;

            if (Request.Cookies["userInfo"] != null)
            {
                userName = Server.HtmlEncode(Request.Cookies["userInfo"]["userName"]);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = "Aplicação modelo para exemplificar um layout padrão.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Procedimento()
        {
            return View();
        }


        public ActionResult Venda()
        {
            return View();
        }

        public ActionResult VDN()
        {
            return View();
        }

    }
}