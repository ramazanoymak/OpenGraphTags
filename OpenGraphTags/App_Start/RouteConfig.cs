using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OpenGraphTags.Controllers;

namespace OpenGraphTags
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(anasayfaController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "anasayfa", action = "Index" }, namespaces);

            routes.MapRoute("login", "login", new { controller = "User", action = "login" }, namespaces);
            routes.MapRoute("logout", "logout", new { controller = "User", action = "logout" }, namespaces);
        }
    }
}