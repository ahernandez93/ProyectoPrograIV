using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;

namespace ProyectoPrograIV
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Database.SetInitializer<Models.BibliotecaDBContext>(new App_Start.BibliotecaDBInitializer());
            //Database.SetInitializer<Models.BibliotecaDBContext>(new App_Start.AutoresDBInitializer());
            //Database.SetInitializer<Models.BibliotecaDBContext>(new App_Start.LibrosDBInitializer());
            //Database.SetInitializer<Models.BibliotecaDBContext>(new App_Start.SolicitudesDBInitializer());
            //Database.SetInitializer<Models.BibliotecaDBContext>(new App_Start.UsuariosDBInitializer());
        }
    }
}
