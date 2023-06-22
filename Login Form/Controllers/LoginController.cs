using Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Form.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(LoginModel log)
        {

            if (log.Username != null && log.Password!= null)
            {
                return View();
            }
            return View("Index");
        }
    }
}