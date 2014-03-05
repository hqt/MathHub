using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MathHub.Framework.HTMLHelper
{
    public static class HtmlHelperExtensions
    {
        public static String NormalizeDate(this HtmlHelper helper, DateTime date)
        {
            DateTime now = DateTime.Now;
            double totalMinutes = now.Subtract(date).TotalMinutes;
            if (totalMinutes < 1)
            {
                return "just now";
            }
            else if (totalMinutes < 60)
            {
                return Math.Truncate(totalMinutes) + " minutes";
            }
            else if (totalMinutes < 24 * 60)
            {
                return Math.Truncate(totalMinutes / 60) + " hours";
            }
            else
            {
                return date.Date + "/" + date.Month + "/" + date.Year;
            }
        }
    }
}
