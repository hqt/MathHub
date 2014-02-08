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
        Tag CreateNewTag(Tag tag);
        Tag EditTag(Tag tag);
        Boolean RemoveTag(Tag tag);
    }
}
