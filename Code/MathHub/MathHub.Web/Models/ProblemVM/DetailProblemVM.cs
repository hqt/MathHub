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


        //public Problem aa;
        //public void a()
        //{
        //    aa.User.Username
        //}
        public int VoteUpNum { get; set; }
        public int VoteDownNum { get; set; }
        public string UserUsername { get; set; }
    }
}