using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Users
{
    public class UserCommandService : IUserCommandService
    {
        MathHubModelContainer ctx;

        public UserCommandService(
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
        }

        public User InsertUser(User user, Profile profile, Image image)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
