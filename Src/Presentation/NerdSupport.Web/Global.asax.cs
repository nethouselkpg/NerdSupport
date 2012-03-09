using System;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using NerdSupport.Infrastructure.Repositories;
using NerdSupport.Infrastructure.Configuration;

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
                    "PrettyDetails",
                    "{Id}",
                        new { controller = "Dinners", action = "Details" },
                        new { Id = @"\d+" }
                    );

            routes.MapRoute(
                    "UpcomingDinners",
                    "Dinners/Page/{page}",
                    new { controller = "Dinners", action = "Index" }
            );

            routes.MapRoute(
                    "Default",                                              // Route name
                    "{controller}/{action}/{id}",                           // URL with parameters
                    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

            routes.MapRoute(
                "OpenIdDiscover",
                "Auth/Discover");

        }

        public override void Init()
        {
          
            base.Init();
        }

        void Application_Start()
        {
            RepositoryInitializer.Init();
            IoC.Init();
            MessageBootstrapper.Init();

            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }

   
    }
}