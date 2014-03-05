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

    public static class DISCUSSION_TAGS 
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
        public const int DEFAULT_PER_WIDGET = 5;
        public const int GET_ALL = int.MaxValue;

        /* so. first loading 5 comments. after that load from 6th */
        public const int DEFAULT_COMMENT_OFFSET = 6;
        public const int DEFAULT_COMMENT_LOADING = 5;

        public const int DEFAULT_REPLY_OFFSET = 6;
        public const int DEFAULT_REPLY_LIMIT = 5;

        public const int DEFAULT_HINT_OFFSET = 6;
        public const int DEFAULT_HINT_LIMIT = 5;
    }

    public static class RouteDefaults
    {
        public const string DEFAULT_PROBLEM_TAB = PROBLEM_TAGS.NEWEST;

        public const string DEFAULT_DISCUSSION_TAB = DISCUSSION_TAGS.NEWEST;
    }
}
