using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Tags;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Tags
{
    public class TagCommandService : ITagCommandService 
    {
        #region Constructor
        MathHubModelContainer ctx;
        IRepository<Tag> tagRepository;
        ILogger logger;

        public TagCommandService(
            IMathHubDbContext ctx,
            IRepository<Tag> tagRepository,
            ILogger logger)
        {
            this.ctx = ctx.GetDbContext();
            this.tagRepository = tagRepository;
            this.logger = logger;
        } 
        #endregion


        public bool CreateNewTag(Entity.Entity.Tag tag)
        {
            return tagRepository.Insert(tag);
        }

        public bool EditTag(Entity.Entity.Tag tag)
        {
            return tagRepository.Update(tag);
        }

        public bool RemoveTag(Entity.Entity.Tag tag)
        {
            return tagRepository.Delete(tag);
        }
    }
}
