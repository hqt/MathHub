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
            List<ScorePermission> scores = ctx.ScorePermissions.OrderBy(t => t.Score).ToList();
            for (int i = 0; i < scores.Count; i++)
            {
                //if (scores[i].Score <= score && score < scores[i + 1].Score)
                //{
                //    return scores[i].Title;
                //}
            }
            return null;
        }

        #region Normal User
        public Profile GetUserProfile(int userId)
        {
            return ctx.Profiles.FirstOrDefault(t => t.User.Id == userId);
        }


        public Tuple<int, int, int> GetMedals(int userId)
        {
            int gold = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.GOLD).Count();
            int silver = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.SILVER).Count();
            int bronze = ctx.Rewards.Where(t => t.UserId == userId).Where(t => t.Medal.Type == MedalEnum.BRONZE).Count();
            return new Tuple<int, int, int>(gold, silver, bronze);
        }


        public IEnumerable<string> getUserFavoriteTagName(int userId)
        {
            return ctx.FavoriteTags.Where(t => t.UserId == userId).Select(t => t.Tag.Name).AsEnumerable();
        }

        public IEnumerable<Tag> getUserFavoriteTag(int userId)
        {
            return ctx.FavoriteTags.Where(t => t.UserId == userId).Select(t => t.Tag).AsEnumerable();
        } 
        #endregion

        #region Login User
        public IEnumerable<Tag> getLoginUserFavoriteTag()
        {
            return ctx.FavoriteTags.Where(t => t.UserId == _authenticationService.GetUserId()).Select(t => t.Tag).AsEnumerable();
        } 
        #endregion


        public IEnumerable<string> getLoginUserFavoriteTagName()
        {
            throw new NotImplementedException();
        }
    }
}
