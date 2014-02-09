using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Tags
{
    public interface ITagCommandService
    {
        bool CreateNewTag(Tag tag);
        bool EditTag(Tag tag);
        bool RemoveTag(Tag tag);
    }
}
