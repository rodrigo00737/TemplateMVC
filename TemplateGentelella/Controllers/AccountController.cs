using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TemplateGentelella.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string senha, string site)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }

            if (login == "admin")
            {
                FormsAuthentication.SetAuthCookie(login, false);
                Response.Cookies["userInfo"]["userName"] = login;
                Response.Cookies["userInfo"].Expires = DateTime.Now.AddMinutes(31);
                Session["User"] = login;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Usuário não cadastrado!";
                return View();
            }
        }
    }
}