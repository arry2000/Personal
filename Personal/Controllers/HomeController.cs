using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string GoogleMapsApiKey = "AIzaSyBDc6EmF7AC5XGMlHUZtEGg2XcopwdODwM";
            return View(model: GoogleMapsApiKey);
        }

        [ChildActionOnly]
        public PartialViewResult Professional()
        {
            DateTime now = DateTime.Today;
            DateTime bday = new DateTime(1995, 4, 29);

            int age = now.Year - bday.Year;
            if (now < bday.AddYears(age)) age--;
            ViewBag.Age = age;

            return PartialView("_Professional", age);
        }

        [ChildActionOnly]
        public PartialViewResult Personal()
        {
            return PartialView("_Personal");
        }

        [ChildActionOnly]
        public PartialViewResult Contact()
        {
            return PartialView("_Contact");
        }


        public ViewResult HappyBirthday(string name)
        {
            ViewBag.HideNav = true;
            return View(model: name);
        }
    }
}