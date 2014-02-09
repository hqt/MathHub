using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Users
{
    public interface IUserQueryService
    {
        /// <summary>
        /// User
        /// </summary>
        Profile GetUserProfile(int userId);
        Tuple<int, int, int> GetMedals(int userId);
        IEnumerable<String> getUserFavoriteTagName(int userId);
        IEnumerable<Tag> getUserFavoriteTag(int userId);



        /// <summary>
        /// Login User
        /// </summary>
        IEnumerable<String> getLoginUserFavoriteTagName();
        IEnumerable<Tag> getLoginUserFavoriteTag();
    }
}
