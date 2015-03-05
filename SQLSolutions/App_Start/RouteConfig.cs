using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SQLSolutions.Controllers;

namespace SQLSolutions
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //var namespaces = new[] { typeof(HomeController).Namespace};
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new {controller = "Auth", action = "Login"});
        }
    }
}