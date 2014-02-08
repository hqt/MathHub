using MathHub.Framework.Infrastructure;
using MathHub.Framework.Infrastructure.AutoMapper;
using MathHub.Framework.Infrastructure.StructureMap;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//using StackExchange.Profiling;
using StructureMap;
using WebMatrix.WebData;

namespace MathHub.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "Users", "Id", "Username", autoCreateTables: true);

            // Config AutoMapper by calling own initialize function
            AutoMapperConfiguration.Configure();
            
            // Using Custom ViewEngine
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomRazorEngine());

            // intialize Interface and Concreted Class
            StructureMapConfiguration.Configure();
        }

        protected void Application_StartRequest()
        {
            if (Request.IsLocal)
            {
                //MiniProfiler.Start();
            } 
        }

        protected void Application_EndRequest()
        {
            ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
            //MiniProfiler.Stop();
        }

    }
}