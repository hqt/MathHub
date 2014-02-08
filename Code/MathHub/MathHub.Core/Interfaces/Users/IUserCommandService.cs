using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Users
{
    public interface IUserCommandService
    {
        User InsertUser(User user, Profile profile, Image image);
        User UpdateUser(User user);
        void DeleteUser(User user);
    }
}
