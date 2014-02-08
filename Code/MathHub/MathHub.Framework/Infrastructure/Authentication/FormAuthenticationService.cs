using System;

namespace MathHub.Framework.Infrastructure.Authentication
{
    public class FormAuthenticationService : IAuthenticationService
    {
        
        /** Detail of Current Login User */
        User user;

        public FormAuthenticationService() {}

        public string Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string Register(string username, string password, object propertyValues)
        {
            throw new NotImplementedException();
        }

        public string Register(string username, string password, object propertyValues, bool requireConfirmToken)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string username, string password, bool rememberMe)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string username, string currentPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public bool IsLogin()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public int GetUserId()
        {
            throw new NotImplementedException();
        }
    }
}
