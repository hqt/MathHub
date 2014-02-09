using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
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
        #region Constructor
        MathHubModelContainer ctx;
        IRepository<User> userRepository;
        IRepository<Profile> profileRepository;
        IRepository<Image> imageRepository;
        IRepository<Activity> activityRepository;
        ILogger logger;

        public UserCommandService(
            IMathHubDbContext context,
            IRepository<User> userRepository,
            IRepository<Profile> profileRepository,
            IRepository<Image> imageRepository,
            IRepository<Activity> activityRepository,
            ILogger logger)
        {
            this.ctx = context.GetDbContext();
            this.userRepository = userRepository;
            this.profileRepository = profileRepository;
            this.imageRepository = imageRepository;
            this.activityRepository = activityRepository;
            this.logger = logger;
        } 
        #endregion

        public bool InsertUser(User user, Profile profile, Image image)
        {
           return userRepository.Insert(user);
        }

        public bool UpdateUser(User user)
        {
            return userRepository.Update(user);
        }

        public bool DeleteUser(User user)
        {
            return userRepository.Delete(user);
        }
    }
}
