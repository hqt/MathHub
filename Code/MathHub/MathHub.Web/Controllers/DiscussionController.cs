using AutoMapper;
using MathHub.Core.Config;
using MathHub.Core.Infrastructure;
using MathHub.Core.Interfaces.Comments;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using MathHub.Web.CustomAnnotation.ActionFilter;
using MathHub.Web.Models.DiscussionVM;
using MathHub.Web.Models.ProblemVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MathHub.Web.Controllers
{
    public partial class DiscussionController : BaseController
    {

        #region Constructor
        private IDiscussionQueryService _discussionQueryService;
        private IDiscussionCommandService _discussionComandService;
        private ICommentCommandService _commentCommandService;
        private IAuthenticationService _authenticationService;
        private ILogger _logger;

        public DiscussionController(
            IDiscussionQueryService discussionQueryService,
            ICommentCommandService commentCommandService,
            IDiscussionCommandService discussionCommandService,
            IAuthenticationService authenticationService,
            ILogger logger)
        {
            this._discussionQueryService = discussionQueryService;
            this._discussionComandService = discussionCommandService;
            this._commentCommandService = commentCommandService;
            this._logger = logger;
        }

        #endregion
     
        //
        // GET: /Discussion/
        public virtual ActionResult Index()
        {
            return RedirectToAction(MathHub.Core.Config.RouteDefaults.DEFAULT_DISCUSSION_TAB);
        }

        // GET /Discussion/Trending
        public virtual ActionResult Trending()
        {
            return View("Views/ListAllDiscussion");
        }

        // GET /Discussion/Mytags
        public virtual ActionResult Mytags()
        {
            return View("Views/ListAllDiscussion");
        }

        // GET /Discussion/Unanswered
        public virtual ActionResult Unanswered()
        {
            return View("Views/ListAllDiscussion");
        }

        // GET /Discussion/Newest
        public virtual ActionResult Newest()
        {
            IEnumerable<Discussion> discussions =
                _discussionQueryService.GetNewestDiscussions(
                Constant.DEFAULT_OFFSET, Constant.DEFAULT_PER_PAGE);

            ICollection<PreviewDiscussionVM> discussionsVms =
                discussions.Select(Mapper.Map<Discussion, PreviewDiscussionVM>).ToList();

            return View("Views/ListAllDiscussion", discussionsVms);
        }
       
        [Authorize]
        [HttpGet]
        // GET /Discussion/Create
        public virtual ActionResult Create()
        {
            return View("Views/CreateDiscussion");
        }

        // POST /Discussion/Create
        [Authorize]
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult Create(CreateDiscussionVM discussionVM)
        {
            if (ModelState.IsValid)
            {
                // create new problem
                Discussion d = new Discussion();
                d.UserId = _authenticationService.GetUserId();
                d.Title = discussionVM.Title;
                d.Content = discussionVM.Content;
                d.DateCreated = DateTime.Now;
                d.DateModified = DateTime.Now;
                bool res = _discussionComandService.AddDiscussion(d);
                if (!res)
                {
                    // by some reason. cannot create discussion
                    ModelState.AddModelError("create_discussion_exception", "This discussion cannot be created. Try again later");
                    return View(discussionVM);
                }
                else
                {
                    return Detail(d.Id);
                }
            }
            else
            {
                // if not ModelState valid
                ModelState.AddModelError("model_state_invalid", "Current State is Invalid");
                return View(discussionVM);
            }
        }

        // GET /Discussion/Detail/1
        public virtual ActionResult Detail(int id)
        {
            Discussion targetDiscussion = _discussionQueryService.GetDiscussionById(id);

            // Map from Model to ViewModel
            DetailDiscussionVM discussionViewModel =
                Mapper.Map<Discussion, DetailDiscussionVM>(targetDiscussion);

            discussionViewModel.CommentPostVm = new MathHub.Web.Models.DiscussionVM.CommentPostVM();
            discussionViewModel.CommentPostVm.MainPostId = discussionViewModel.Id;
            discussionViewModel.CommentPostVm.Type = "discussion";

            return View("Views/DetailDiscussion", discussionViewModel);
        }

        //[AjaxCallActionFilter]
        //public virtual ActionResult Answer(int id, int offset)
        //{
        //    IEnumerable<Reply> answers = _problemQueryService.GetAllReplies(
        //            id,
        //            ReplyEnum.ANSWER,
        //            offset,
        //            Constant.DEFAULT_PER_PAGE
        //        ).AsEnumerable();

        //    ICollection<AnswerItemVM> answerItemVms = answers.Select(Mapper.Map<Reply, AnswerItemVM>).ToList();
        //    AnswerListVM answerListVm = new AnswerListVM();
        //    answerListVm.AnswerItemVms = answerItemVms;
        //    return PartialView("Partials/_AnswerList", answerListVm);
        //}

        //[AjaxCallActionFilter]
        //public virtual ActionResult Hint(int postId, int offset)
        //{
        //    IEnumerable<Reply> hints = _problemQueryService.GetAllReplies(
        //            postId,
        //            ReplyEnum.HINT,
        //            offset,
        //            Constant.DEFAULT_PER_PAGE
        //        ).AsEnumerable();

        //    // Map list models to list viewmodels with lambda expression 
        //    ICollection<HintItemVM> hintItemVms = hints.Select(Mapper.Map<Reply, HintItemVM>).ToList();
        //    HintListVM hintListVm = new HintListVM();
        //    hintListVm.HintItemVms = hintItemVms;
        //    return PartialView("Partials/_HintList", hintListVm);
        //}

        //[AjaxCallActionFilter]
        //public virtual ActionResult Comment(int postId, int offset)
        //{
        //    offset = offset < 0 ? Constant.DEFAULT_COMMENT_OFFSET : offset;
        //    int limit = offset < 0 ? int.MaxValue : Constant.DEFAULT_COMMENT_LOADING;

        //    IEnumerable<Comment> comments = _problemQueryService.GetAllComments(
        //        postId,
        //        offset,
        //        limit
        //        );

        //    // Map list models to list viewmodels with lambda expression 
        //    ICollection<CommentItemVM> hintItemVms = comments.Select(Mapper.Map<Comment, CommentItemVM>).ToList();

        //    CommentListVM commentListVm = new CommentListVM();

        //    commentListVm.CommentItemVms = hintItemVms;
        //    return PartialView("Partials/_CommentList", commentListVm);
        //}

        [Authorize]
        public bool AddComment(MathHub.Web.Models.DiscussionVM.CommentPostVM commentPostVm)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();
                comment.UserId = WebSecurity.CurrentUserId;
                comment.DateCreated = DateTime.Now;
                comment.Content = commentPostVm.Content;

                switch (commentPostVm.Type)
                {
                    case "problem":
                        //comment.MainPostId = commentPostVm.MainPostId;
                        return _commentCommandService.AddCommentForPost((int)commentPostVm.MainPostId, comment);

                    case "Reply":
                        //comment.ReplyId = commentPostVm.ReplyId;
                        return _commentCommandService.AddCommentForReply((int)comment.ReplyId, comment);

                    default:
                        return false;
                }
            }
            else
            {
                // ModelState is not valid
                return false;
            }
        }

    }
}
