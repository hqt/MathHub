using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using System.Threading.Tasks;

namespace MathHub.Core.Infrastructure
{
    public interface IRouteProvider
    {
        void RegisterRoutes(RouteCollection routes);
        int Priority { get; }
    }
}
