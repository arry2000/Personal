using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime now = DateTime.Today;
            DateTime bday = new DateTime(1995, 4, 29);
            int age = now.Year - bday.Year;
            if (now < bday.AddYears(age)) age--;
            ViewBag.Age = age;

            ViewBag.GoogleMapsApiKey = "AIzaSyBDc6EmF7AC5XGMlHUZtEGg2XcopwdODwM";

            return View();
        }
    }
}