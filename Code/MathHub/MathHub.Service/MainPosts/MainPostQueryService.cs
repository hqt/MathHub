//using MathHub.Core.Infrastructure.Repository;
//using MathHub.Core.Interfaces.MainPosts;
//using MathHub.Entity.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MathHub.Service.MainPosts
//{
//    public abstract class MainPostQueryService : IMainPostQueryService
//    {
//        MathHubModelContainer ctx;

//        public MainPostQueryService(IMathHubDbContext mathHubDbContext)
//        {
//            this.ctx = mathHubDbContext.GetDbContext();
//        }

//        public List<Entity.Entity.Tag> GetAllMainPostTag(int postId)
//        {
//            throw new NotImplementedException();
//        }

//        public List<string> GetAllMainPostTagName(int postId)
//        {
//            throw new NotImplementedException();
//        }

//        public Entity.Entity.MainPost GetMainPostDetail(int postId)
//        {
//            throw new NotImplementedException();
//        }

//        public int GetPostVoteUp(int postId)
//        {
//            return ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
//        }

//        public int GetPostVoteDown(int postId)
//        {
//            return ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
//        }

//        public Tuple<int, int> GetPostVote(int postId)
//        {
//            int voteUp = ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
//            int voteDown = ctx.Votes.Where(t => t.Type == VoteEnum.DOWNVOTE).Count(t => t.Post.Id == postId);
//            return new Tuple<int, int>(voteUp, voteDown);
//        }


//        public IQueryable<Comment> GetAllComments(int postId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
