using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models
{
    public class DetailProblemViewModel
    {
        public int TestId { get; set; }
        public DetailProblemViewModel(int id)
        {
            TestId = id;
        }
    }
}