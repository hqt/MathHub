using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Discussions
{
    public class DiscussionQueryService : IDiscussionQueryService
    {
        MathHubModelContainer ctx;
        IRepository<Discussion> discussionRepository;

        public DiscussionQueryService(
            IRepository<Discussion> discussionRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
            this.discussionRepository = discussionRepository;
        }

        public List<Tag> GetAllMainPostTag(int postId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllMainPostTagName(int postId)
        {
            throw new NotImplementedException();
        }

        public MainPost GetMainPostDetail(int postId)
        {
            throw new NotImplementedException();
        }


        public int GetPostVoteUp(int postId)
        {
            throw new NotImplementedException();
        }

        public int GetPostVoteDown(int postId)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, int> GetPostVote(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
