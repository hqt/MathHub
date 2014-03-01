using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MathHub.Framework.Infrastructure.AutoMapper
{
    public static class TupleMapperResolver 
    {
        public class TripleTuple : ValueResolver<Tuple<int, int, int>, Tuple<int, int, int>>
        {
            protected override Tuple<int, int, int> ResolveCore(Tuple<int, int, int> source)
            {
                return new Tuple<int, int, int>(source.Item1, source.Item2, source.Item3);
            }
        }

        public class DoubleTuple : ValueResolver<Tuple<int, int>, Tuple<int, int>>
        {
            protected override Tuple<int, int> ResolveCore(Tuple<int, int> source)
            {
                return new Tuple<int, int>(source.Item1, source.Item2);
            }
        }


    }
}
