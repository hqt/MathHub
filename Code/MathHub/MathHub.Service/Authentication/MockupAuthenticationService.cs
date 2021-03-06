﻿using System;
using System.Linq;
using MathHub.Core.Infrastructure;
using MathHub.Entity.Entity;
using WebMatrix.WebData;

namespace MathHub.Framework.Infrastructure.Authentication
{
    /// <summary>
    /// Use this class for testing purpose until we have log-in function
    /// </summary>
    public class MockupAuthenticationService : IAuthenticationService
    {
        /** Current Login User */
        User user = new User();

        public MockupAuthenticationService()
        {

        }


        public string Register(string username, string password)
        {
            return WebSecurity.CreateUserAndAccount(username, password);
        }

        public string Register(string username, string password, object propertyValues)
        {
            return WebSecurity.CreateUserAndAccount(username, password, propertyValues);
        }

        public string Register(string username, string password, object propertyValues, bool requireConfirmToken)
        {
            return WebSecurity.CreateUserAndAccount(username, password, propertyValues, requireConfirmToken);
        }

        public Boolean SignIn(String username, String password, Boolean rememberMe)
        {
            //user = ctx.Users.FirstOrDefault(t => t.Username.Equals(username));
            return WebSecurity.Login(username, password, persistCookie: rememberMe);
        }

        public bool SignIn(string username, string password)
        {
            //user = ctx.Users.FirstOrDefault(t => t.Username.Equals(username));
            return WebSecurity.Login(username, password);
        }

        public bool ChangePassword(string username, string currentPassword, string newPassword)
        {
            return WebSecurity.ChangePassword(username, currentPassword, newPassword);
        }

        public void SignOut()
        {
            user = new User();
            WebSecurity.Logout();
        }

        public bool IsLogin()
        {
            return WebSecurity.IsAuthenticated;
        }

        public string GetUserName()
        {
            return user.Username;
        }

        public int GetUserId()
        {
            return WebSecurity.GetUserId(user.Username);
        }


        public User getUser()
        {
            throw new NotImplementedException();
        }
    }
}
