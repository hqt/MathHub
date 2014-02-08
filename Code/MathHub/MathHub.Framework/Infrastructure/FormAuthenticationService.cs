using MathHub.Core.Infrastructure;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure
{
    public class FormAuthenticationService : IAuthenticationService
    {
        
        /** Detail of Current Login User */
        User user;

        public FormAuthenticationService() {}

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
            throw new NotImplementedException();
        }

        public string getUserName()
        {
            throw new NotImplementedException();
        }

        public int getUserId()
        {
            throw new NotImplementedException();
        }
    }
}
