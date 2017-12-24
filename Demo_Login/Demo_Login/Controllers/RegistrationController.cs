using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Login.Models;

namespace Demo_Login.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        RegistrationContext regdbcon = new RegistrationContext();
        public ActionResult Index()
        {
            var registerlist = (from a in regdbcon.Registration_Master
                            select a).ToList();
            return View(registerlist);
        }

        [HttpGet]
        public ActionResult Register()
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
        public ActionResult Register(Registration_Master addnewreg)
        {
            Registration_Master addnewregister = new Registration_Master();
            addnewregister.FirstName = addnewreg.FirstName;
            addnewregister.LastName = addnewreg.LastName;
            addnewregister.Email = addnewreg.Email;
            addnewregister.Password = "System123#";
            addnewregister.ContactNo = addnewreg.ContactNo;
            addnewregister.Role = addnewreg.Role;
            regdbcon.Registration_Master.Add(addnewregister);
            regdbcon.SaveChanges();
            return RedirectToAction("Index", "Registration");
        }

    }
}