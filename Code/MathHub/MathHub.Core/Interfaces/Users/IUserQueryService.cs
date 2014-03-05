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
        User GetLoginUser();

        /// <summary>
        /// User Profile
        /// </summary>
        User GetUserById(int userId);
        User GetLoginById();

        string GetUseAvatar(int userId);
        string GetLoginAvatar();

        Profile GetUserProfile(int userId);
        Profile GetLoginProfile();

        Tuple<int, int, int> GetUserMedals(int userId);
        Tuple<int, int, int> GetLoginMedals();

        /// <summary>
        /// Tag
        /// </summary>
        IEnumerable<String> GetUserFavoriteTagName(int userId);
        IEnumerable<String> GetLoginFavoriteTagName();

        IEnumerable<Tag> GetUserFavoriteTag(int userId);
        IEnumerable<Tag> GetLoginFavoriteTag();

        /// <summary>
        /// Subscription
        /// </summary>

        IEnumerable<Subscription> GetUserAllSubscriptions(int followerId);
        IEnumerable<Subscription> GetLoginAllSubscriptions();

        int GetTotalUnseenSubscription(int follower, int following);
        int GetLoginTotalUnseenSubscription(int following);

        IEnumerable<int> GetFollowingIds(int follower);
        IEnumerable<int> GetLoginFollowingIds();
        
        IEnumerable<Tuple<int, int>> GetTotalUnseenSubscription(int follower);
        IEnumerable<Tuple<int, int>> GetLoginTotalUnseenSubscription();
    }
}
