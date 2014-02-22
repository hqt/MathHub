using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Tags
{
    public interface ITagQueryService
    {
        IEnumerable<String> GetAllTagsOfUser(int id);
        IEnumerable<Tag> GetAllTagsDetailOfUser(int id);
        IEnumerable<Tag> GetAllTagsStartWith(string str);
    }
}
