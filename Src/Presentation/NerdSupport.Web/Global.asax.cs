using System;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using NerdSupport.Infrastructure.Configuration;
using NerdSupport.Domain.Repositories;
using Nerdsupport.Presentation.ViewModels;

namespace NerdSupport.Presentation.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                    "Default",                                              // Route name
                    "{controller}/{action}/{id}",                           // URL with parameters
                    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );


        }

        public override void Init()
        {

            base.Init();
        }

        void Application_Start()
        {
            Booter.Boot();

            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }


    }
}