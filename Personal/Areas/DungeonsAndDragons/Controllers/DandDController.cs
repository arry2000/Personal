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

        public ViewResult GetMap(string region)
        {
            string viewName = string.Empty;
            switch(region)
            {
                case "IONA":
                    viewName = "Iona";
                    break;
                case "CIENDOR":
                    viewName = "Ciendor";
                    break;
                case "BRUSLAND MOUNTAINS":
                    viewName = "BruslandMountains";
                    break;
                case "AMDRIN":
                    viewName = "Amdrin";
                    break;
                case "BARREN WILDLANDS":
                    viewName = "BarrenWildlands";
                    break;
                default:
                    break;
            }
            return View(viewName);
        }

        //public PartialViewResult GetMaps(string region)
        //{
        //    string partialViewName = "";
        //    switch (region)
        //    {
        //        case "WORLD":
        //            partialViewName = "_World";
        //            break;
        //        case "IONA":
        //            partialViewName = "_Iona";
        //            break;
        //        case "CIENDOR":
        //            partialViewName = "_Ciendor";
        //            break;
        //        case "BRUSLAND MOUNTAINS":
        //            partialViewName = "_BruslandMountains";
        //            break;
        //        case "AMDRIN":
        //            partialViewName = "_Amdrin";
        //            break;
        //        case "BARREN WILDLANDS":
        //            partialViewName = "_BarrenWildlands";
        //            break;
        //        default:
        //            break;
        //    }

        //    return PartialView(partialViewName);
        //}
    }
}