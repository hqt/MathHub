using System;
using System.Linq;
using System.Reflection;
using MathHub.Framework.Infrastructure;
using MathHub.Framework.Infrastructure.AutoMapper;
using MathHub.Framework.Infrastructure.StructureMap;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MathHub.Framework.Utils;
using StructureMap;
using WebMatrix.WebData;
using AutoMapper;
using StackExchange.Profiling;

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
            var profileType = typeof(Profile);
            // Get an instance of each Profile in the executing assembly.
            var profiles = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => profileType.IsAssignableFrom(t)
                    && t.GetConstructor(Type.EmptyTypes) != null)
                .Select(Activator.CreateInstance)
                .Cast<Profile>();

            // Initialize AutoMapper with each instance of the profiles found.
            Mapper.Initialize(a => profiles.ForEach(a.AddProfile));
            
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
                MiniProfiler.Start();
            }
        }

        protected void Application_EndRequest()
        {
            ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
            MiniProfiler.Stop();
        }

    }
}