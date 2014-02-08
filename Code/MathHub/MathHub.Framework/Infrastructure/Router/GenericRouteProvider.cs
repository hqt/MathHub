using MathHub.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure.Router
{
    class GenericRouteProvider : IRouteProvider
    {
        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            throw new NotImplementedException();
        }

        public int Priority
        {
            get
            {
                //it should be the last route
                //we do not set it to -int.MaxValue so it could be overriden (if required)
                return -1000000;
            }
        }
    }
}
