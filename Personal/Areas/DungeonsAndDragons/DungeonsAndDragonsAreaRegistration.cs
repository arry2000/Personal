using System.Web.Mvc;

namespace Personal.Areas.DungeonsAndDragons
{
    public class DungeonsAndDragonsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DungeonsAndDragons";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DungeonsAndDragons_default",
                "DungeonsAndDragons/{controller}/{action}/{id}",
                new { controller = "DandD", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}