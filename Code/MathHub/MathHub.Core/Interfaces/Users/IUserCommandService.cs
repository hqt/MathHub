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
        bool InsertUser(User user, Profile profile, Image image);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
    }
}
