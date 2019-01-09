using System.Web.Mvc;

namespace Personal.Areas.Swgoh
{
    public class SwgohAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Swgoh";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Swgoh_default",
                "Swgoh/{controller}/{action}/{id}",
                new { controller = "Swgoh",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}