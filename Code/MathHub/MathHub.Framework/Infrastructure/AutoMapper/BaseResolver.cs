using AutoMapper;
using MathHub.Web.Framework.Utils;

namespace MathHub.Framework.Infrastructure.AutoMapper
{
    public abstract class BaseResolver<T, TReturn> : IValueResolver
    {
        public object Resolve(object model)
        {
            return ResolveCore((T)model);
        }

        protected abstract TReturn ResolveCore(T model);

        //public ResolutionResult Resolve(ResolutionResult source)
        //{
        //    return new ResolutionResult(ResolveCore((T)source.Value));
        //}

        public ResolutionResult Resolve(ResolutionResult source)
        {
            throw new System.NotImplementedException();
        }
    }
}
