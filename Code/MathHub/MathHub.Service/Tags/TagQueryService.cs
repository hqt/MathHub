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

        public IEnumerable<string> GetAllTagsOfUser(int id)
        {
            return ctx.FavoriteTags
                .Include(t => t.Tag)
                .Where(t => t.UserId == id)
                .Select(t => t.Tag.Name)
                .AsEnumerable();
        }

        public IEnumerable<Tag> GetAllTagsDetailOfUser(int id)
        {
            return ctx.FavoriteTags
                .Include(t => t.Tag)
                .Where(t => t.UserId == id)
                .Select(t => t.Tag)
                .AsEnumerable();
        }


        public IEnumerable<Tag> GetAllTagsStartWith(string str)
        {
            return ctx.Tags
                .Where(t => t.Name.StartsWith(str) == true)
                .AsEnumerable();
        }
    }
}
