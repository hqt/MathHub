using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHub.Entity.Entity;

namespace MathHub.Core.Infrastructure
{
    /// <summary>
    /// Use this Interface through out application to know current authentication
    /// temporary method. just place here. need think more ...
    /// </summary>
    public interface IAuthenticationService
    {
        String Register(String username, String password);
        String Register(String username, String password, Object propertyValues);
        String Register(String username, String password, Object propertyValues, Boolean requireConfirmToken);
        Boolean SignIn(String username, String password, Boolean rememberMe);
        Boolean SignIn(String username, String password);
        Boolean ChangePassword(String username, String currentPassword, String newPassword);
        void SignOut();
        Boolean IsLogin();
        String GetUserName();
        int GetUserId();
    }
}
