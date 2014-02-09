using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.CommonVM
{
    public class ProfileWidgetVM
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public Tuple<int, int, int> Medal { get; set; }    
    }
}