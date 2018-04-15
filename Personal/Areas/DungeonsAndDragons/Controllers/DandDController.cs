using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Areas.DungeonsAndDragons.Controllers
{
    public class DandDController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult WorldMap()
        {
            return View();
        }

        public PartialViewResult GetMaps(string region)
        {
            string partialViewName = "";
            switch (region)
            {
                case "WORLD":
                    partialViewName = "_World";
                    break;
                case "IONA":
                    partialViewName = "_Iona";
                    break;
                case "CIENDOR":
                    partialViewName = "_Ciendor";
                    break;
                case "BRUSLAND MOUNTAINS":
                    partialViewName = "_BruslandMountains";
                    break;
                default:
                    break;
            }

            return PartialView(partialViewName);
        }
    }
}