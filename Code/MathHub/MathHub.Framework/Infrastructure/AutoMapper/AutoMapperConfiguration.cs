using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHub.Web.Framework.Utils;

namespace MathHub.Framework.Infrastructure
 {
    public class AutoMapperConfiguration
    {
        public static Func<Type, object> CreateDependencyCallback = (type) => Activator.CreateInstance(type);

        public static void Configure()
        {
            Mapper.Initialize(x  => 
                x.AddProfile<MathHubMapperProfile>());

            //Mapper.Initialize(x =>
            //{
            //    x.ConstructServicesUsing(type => CreateDependencyCallback(type));
            //    GetProfiles().ForEach(type => x.AddProfile((Profile)Activator.CreateInstance(type)));
            //});
        }

        private static IEnumerable<Type> GetProfiles()
        {
            foreach (Type type in typeof(AutoMapperConfiguration).Assembly.GetTypes())
            {
                if (!type.IsAbstract && typeof(Profile).IsAssignableFrom(type))
                    yield return type;
            }
        }

    }
}
