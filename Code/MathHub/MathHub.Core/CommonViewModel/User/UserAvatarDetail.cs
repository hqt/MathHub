using MathHub.Core.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.CommonViewModel.User
{
    /// <summary>
    /// Using this ViewModel to display User Detail Information before each post. Reply ...
    /// </summary>
    public class UserAvatarDetail
    {
        /// <summary>
        /// Fields
        /// </summary>
        public int Id { get; set; }
        public String UserName { get; set; }
        public String UserAvatarLink { get; set; }
        public Boolean isSubcribed { get; set; }
        public int GoldMedalNum { get; set; }
        public int BronzeMedalNum { get; set; }
        public int SilverMedalNum { get; set; }
        public int? UserScore { get; set; }
        public String UserTitle { get; set; }
    }
}
