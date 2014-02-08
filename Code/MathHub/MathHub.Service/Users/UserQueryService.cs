using MathHub.Core.Interfaces.Users;
using MathHub.Core.CommonViewModel.User;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Repository;

namespace MathHub.Service.Users
{
    public class UserQueryService : IUserQueryService
    {
         MathHubModelContainer ctx;
         IAuthenticationService _authenticationService;

         public UserQueryService(
             IMathHubDbContext MathHubDbContext, 
             IAuthenticationService authenticationService)
        {
            ctx = MathHubDbContext.GetDbContext();
            this._authenticationService = authenticationService;
        }

        public Core.CommonViewModel.User.UserAvatarDetail GetUserAvatarById(int id)
        {
            User user = ctx.Users.Include(t => t.Avatar).FirstOrDefault(t => t.Id == id);

            UserAvatarDetail vm = new UserAvatarDetail();
            vm.UserName = user.Username;
            vm.UserTitle = "";
            vm.UserScore = user.Score;
            vm.UserAvatarLink = user.Avatar != null ? user.Avatar.Url : "";
            vm.GoldMedalNum = ctx.Rewards.Where(t => t.UserId == user.Id).Where(t => t.Medal.Type == MedalEnum.GOLD).Count();
            vm.SilverMedalNum = ctx.Rewards.Where(t => t.UserId == user.Id).Where(t => t.Medal.Type == MedalEnum.SILVER).Count();
            vm.BronzeMedalNum = ctx.Rewards.Where(t => t.UserId == user.Id).Where(t => t.Medal.Type == MedalEnum.BRONZE).Count();

            return vm;
        }

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

        public UserAvatarDetail GetCurrentLoginUser()
        {
            int userId = _authenticationService.GetUserId();
            return GetUserAvatarById(userId);
        }

        public List<string> getLoginUserFavoriteTag()
        {
            int userId = _authenticationService.GetUserId();
            if (userId == 0) return new List<string>();

            return ctx.FavoriteTags.Include(t => t.Tag)
                .Where(t => t.UserId == userId).Select(t => t.Tag.Name).ToList();
        }

        public UserAvatarDetail GetUserAvatarByPostId(int id)
        {
            UserAvatarDetail vm = new UserAvatarDetail();
            int userId = ctx.Posts.Include(t => t.User)
                .SingleOrDefault(t => t.Id == id).User.Id;
            return GetUserAvatarById(userId);
        }

        public Profile GetUserProfile(int userId)
        {
            return ctx.Profiles.Include(t => t.User).FirstOrDefault(t => t.User.Id == userId);
        }
    }
}
