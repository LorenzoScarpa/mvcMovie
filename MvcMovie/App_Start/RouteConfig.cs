using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default2",
            //    url: "{controller}/{action}/{id}/{numTimes}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, numTimes = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Root2",
                url: "{controller}/{action}/{name}/{numTimes}",
                defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional, numTimes = UrlParameter.Optional }
            );

             
        }
    }
}
