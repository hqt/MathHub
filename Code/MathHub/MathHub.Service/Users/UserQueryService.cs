using MathHub.Core.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Entity.Entity;

namespace MathHub.Service.Users
{
    public class UserQueryService : IUserQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;
        IAuthenticationService _authenticationService;

        public UserQueryService(
            IMathHubDbContext MathHubDbContext,
            IAuthenticationService authenticationService)
        {
            ctx = MathHubDbContext.GetDbContext();
            this._authenticationService = authenticationService;
        } 
        #endregion

        public String getTitleByScore(int score)
        {
            throw new NotImplementedException();
        }

        #region User Profile
        public Profile GetUserProfile(int userId)
        {
            return ctx.Profiles.FirstOrDefault(t => t.User.Id == userId);
        }

        public Profile GetLoginProfile()
        {
            int userId = _authenticationService.GetUserId();
            return GetUserProfile(userId);
        }

        public Tuple<int, int, int> GetUserMedals(int userId)
        {
            int gold = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.GOLD).Count();
            int silver = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.SILVER).Count();
            int bronze = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.BRONZE).Count();
            return new Tuple<int, int, int>(gold, silver, bronze);
        }

        public Tuple<int, int, int> GetLoginMedals()
        {
            int userId = _authenticationService.GetUserId();
            return GetUserMedals(userId);
        }
        #endregion

        #region User Tag
        public IEnumerable<string> GetUserFavoriteTagName(int userId)
        {
            return ctx.FavoriteTags.Where(t => t.UserId == userId).Select(t => t.Tag.Name).AsEnumerable();
        }

        public IEnumerable<string> GetLoginFavoriteTagName()
        {
            int userId = _authenticationService.GetUserId();
            return GetUserFavoriteTagName(userId);
        }

        public IEnumerable<Tag> GetUserFavoriteTag(int userId)
        {
            return ctx.FavoriteTags.Where(t => t.UserId == userId).Select(t => t.Tag).AsEnumerable();
        }

        public IEnumerable<Tag> GetLoginFavoriteTag()
        {
            int id = _authenticationService.GetUserId();
            return GetUserFavoriteTag(id);
        }
        #endregion

        #region User Subscription
        public IEnumerable<Subscription> GetUserAllSubscriptions(int followerId)
        {
            return ctx.Subscriptions.Where(s => s.FollowerId == followerId);
        }

        public IEnumerable<Subscription> GetLoginAllSubscriptions()
        {
            int userId = _authenticationService.GetUserId();
            return GetUserAllSubscriptions(userId);
        }

        public IEnumerable<int> GetFollowingIds(int follower)
        {
            return ctx.Subscriptions
                .Where(s => s.FollowerId == follower)
                .Select(s => s.FollowingId)
                .AsEnumerable();
        }

        public IEnumerable<int> GetLoginFollowingIds()
        {
            int followerId = _authenticationService.GetUserId();
            return GetFollowingIds(followerId);
        }

        public IEnumerable<Tuple<int, int>> GetTotalUnseenSubscription(int follower)
        {
            IEnumerable<int> ids = GetFollowingIds(follower);
            List<Tuple<int, int>> res = new List<Tuple<int, int>>();
            foreach (int id in ids)
            {
                int nUnseenSubscription = ctx.Subscriptions.Count
                    (s => s.FollowerId == follower &&
                        s.FollowingId == id &&
                        s.DateSeen.CompareTo(s.DateCreated) == 0);
                res.Add(new Tuple<int, int>(id, nUnseenSubscription));
            }
            return res;
        }

        public IEnumerable<Tuple<int, int>> GetLoginTotalUnseenSubscription()
        {
            int followerId = _authenticationService.GetUserId();
            return GetTotalUnseenSubscription(followerId);
        }

        public int GetTotalUnseenSubscription(int follower, int following)
        {
            return ctx.Subscriptions.Count(
                s => s.FollowerId == follower &&
                    s.FollowingId == following &&
                    s.DateSeen.CompareTo(s.DateCreated) == 0);
        }
       
        public int GetLoginTotalUnseenSubscription(int following)
        {
            int followerId = _authenticationService.GetUserId();
            return GetTotalUnseenSubscription(followerId, following);
        }

        #endregion

        #region User
        public string GetUseAvatar(int userId)
        {
            // a method to combine FirstOrDefault with Select query
            return ctx.Images
                .Where(m => m.User.Id == userId)
                .Select(m => m.Url)
                .FirstOrDefault();
        }

        public string GetLoginAvatar()
        {
            int userId = _authenticationService.GetUserId();
            return GetUseAvatar(userId);
        }

        public User GetLoginUser()
        {
            return _authenticationService.getUser();
        }

        public User GetUserById(int userId)
        {
            return ctx.Users.FirstOrDefault(u => u.Id == userId);
        }

        public User GetLoginById()
        {
            return _authenticationService.getUser();
        }

        #endregion
    }
}
