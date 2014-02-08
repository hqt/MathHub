using System.Collections.Generic;
using MathHub.Entity.Entity;

namespace MathHub.Web.Models.ProblemVM
{
    public class DetailProblemVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public ICollection<BlogProblem> BlogProblems { get; set; }
        public ICollection<DiscusstionProblem> DiscusstionProblems { get; set; }
        public ICollection<Invitation> Invitations { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<FavoritePost> FavoritePosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ViewHit> ViewHits { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public ICollection<Share> Shares { get; set; }
        public User User { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public ICollection<FollowPost> Follows { get; set; }


        //public Problem aa;
        //public void a()
        //{
        //    aa.C
        //}

        public int VoteUpNum { get; set; }
        public int VoteDownNum { get; set; }
        public string UserUsername { get; set; }
    }
}