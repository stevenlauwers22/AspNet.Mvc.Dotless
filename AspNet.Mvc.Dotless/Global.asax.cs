﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNet.Mvc.Dotless
{
	public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RegisterRoutes();
        }

        private static void RegisterRoutes()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            RouteTable.Routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
	}
}