using MathHub.Core.CommonViewModel.User;
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
        UserAvatarDetail GetUserAvatarById(int id);
        UserAvatarDetail GetUserAvatarByPostId(int id);
        Profile GetUserProfile(int id);
        UserAvatarDetail GetCurrentLoginUser();
        List<String> getLoginUserFavoriteTag();
    }
}
