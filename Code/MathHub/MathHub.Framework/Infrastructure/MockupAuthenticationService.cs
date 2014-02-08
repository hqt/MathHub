using MathHub.Core.Infrastructure;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure
{
    /// <summary>
    /// Use this class for testing purpose until we have log-in function
    /// </summary>
    public class MockupAuthenticationService : IAuthenticationService
    {
        /** Current Login User */
        User user;
        MathHubModelContainer ctx = new MathHubModelContainer();

        public MockupAuthenticationService()
        {
            // temporary login with Thanh Hai User 
            user = ctx.Users.FirstOrDefault(t => t.Id == 10);
        }


        public void SignIn()
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public bool isLogin()
        {
            return user != null;
        }

        public string getUserName()
        {
            return user.Username;
        }

        public int getUserId()
        {
            return user.Id;
        }
    }
}
