using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathHub.Entity.Entity;

namespace MathHub.Web.Models.CommonVM
{
    public class ProfileWidgetVM
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public Tuple<int, int, int> Medal { get; set; }
        public string Avatar { get; set; }
    }
}