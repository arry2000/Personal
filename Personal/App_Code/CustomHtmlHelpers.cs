using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Personal.App_Code
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString ActionLinkWithFontAwesomeIcon(this HtmlHelper htmlHelper, string linkText, string action, string controller, object routeValues, object htmlAttributes, string fontAwesomeClasses)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            var icon = new TagBuilder("i");

            string[] split = fontAwesomeClasses.Split(' ');
            foreach (string cssClass in split)
            {
                icon.AddCssClass(cssClass);
            }

            if (!icon.Attributes["class"].Split().Contains("fa"))
            {
                icon.AddCssClass("fa");
            }

            var anchor = new TagBuilder("a");
            anchor.InnerHtml = icon.ToString(TagRenderMode.Normal);
            anchor.InnerHtml += " " + linkText;
            anchor.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
            anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(anchor.ToString());
        }
    }
}