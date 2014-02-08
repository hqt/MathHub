using MathHub.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure.Router
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            
        }


        public int Priority
        {
            get { return 0; }
        }
    }
}
