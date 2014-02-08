using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Config
{

    public static class PROBLEM_TAGS
    {
        public const string NEWEST = "Newest";
        public const string TRENDING = "Trending";
        public const string MYTAGS = "Mytags";
        public const string UNANSWERED = "Unanswered";
    }

    public static class Constant
    {
        public const int DEFAULT_OFFSET = 0;
        public const int DEFAULT_PER_PAGE = 10;
    }

    public static class RouteDefaults
    {
        public const string DEFAULT_PROBLEM_TAB = PROBLEM_TAGS.NEWEST;
    }
}
