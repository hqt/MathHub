using MathHub.Core.Interfaces.Tags;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MathHub.Service.Tags
{
    public class TagQueryService : ITagQueryService
    {
        MathHubModelContainer ctx = new MathHubModelContainer();
 
        public List<string> GetAllTagsOfUser(int id)
        {
            return ctx.FavoriteTags.Include(t => t.Tag).
                Where(t => t.UserId == id).Select(t => t.Tag.Name).ToList();
        }

        public List<Tag> GetAllTagDetailOfUser(int id)
        {
            return ctx.FavoriteTags.Include(t => t.Tag).
                Where(t => t.UserId == id).Select(t => t.Tag).ToList();
        }
    }
}
