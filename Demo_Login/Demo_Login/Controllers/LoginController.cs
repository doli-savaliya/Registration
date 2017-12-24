using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Login.Models;

namespace Demo_Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        RegistrationContext regdbcon = new RegistrationContext();
        [HttpGet]
        public ActionResult Index()
        {
            var rolelist = (from a in regdbcon.Role_Master
                            select a).ToList();

            var rolelistData = rolelist.Select(m => new SelectListItem()
            {
                Text = m.RoleName,
                Value = m.ID.ToString(),
            });
            //Assigning generic list to ViewBag
            ViewBag.rolelisting = rolelistData;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration_Master reglogin)
        {
            var checkusername = (from a in regdbcon.Registration_Master
                                 where a.Email == reglogin.Email && a.Password == reglogin.Password
                                 select a).ToList();
            Session["userid"] = checkusername[0].ID.ToString();
            if (checkusername.Count>0)
            {
                return RedirectToAction("showprofile", "Login");
            }
            return View();
        }
        public ActionResult showprofile()
        {
            int sessionid = Convert.ToInt32(Session["userid"]);
            var checkusername = (from a in regdbcon.Registration_Master
                                 where a.ID== sessionid
                                 select a).ToList();
            return View(checkusername);
        }

    }
}