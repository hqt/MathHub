using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Utils
{
    public static class DataUtils
    {
        /// <summary>
        /// Get unproxied entity type
        /// </summary>
        /// <remarks> 
        /// If your Entity Framework context is proxy-enabled, 
        /// the runtime will create a proxy instance of your entities, 
        /// i.e. a dynamically generated class which inherits from your entity class 
        /// and overrides its virtual properties by inserting specific code useful for example 
        /// for tracking changes and lazy loading.
        /// </remarks>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Type GetUnproxiedEntityType<T>(this T entity)
        {
            var userType = ObjectContext.GetObjectType(entity.GetType());
            return userType;
        }
    }
}
