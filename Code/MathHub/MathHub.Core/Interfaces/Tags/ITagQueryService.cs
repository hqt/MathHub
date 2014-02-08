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
        List<String> GetAllTagsOfUser(int id);
        List<Tag> GetAllTagDetailOfUser(int id);
    }
}
