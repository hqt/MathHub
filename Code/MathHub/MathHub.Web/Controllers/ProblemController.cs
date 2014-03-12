﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MathHub.Core.Interfaces.Comments;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using AutoMapper;
using MathHub.Web.Models.ProblemVM;
using MathHub.Core.Config;
using MathHub.Web.CustomAnnotation.ActionFilter;
using WebMatrix.WebData;
using MathHub.Core.Infrastructure;
using MathHub.Web.Models.CommonVM;

namespace MathHub.Web.Controllers
{
    public partial class ProblemController : BaseController
    {

        private IProblemQueryService _problemQueryService;
        private IProblemCommandService _problemCommandService;
        private ICommentCommandService _commentCommandService;
        private IAuthenticationService _authenticationService;

        public ProblemController(
            IProblemQueryService problemQueryService,
            ICommentCommandService commentCommandService,
            IProblemCommandService problemCommandService,
            IAuthenticationService authenticationService)
        {
            _problemQueryService = problemQueryService;
            _commentCommandService = commentCommandService;
            _problemCommandService = problemCommandService;
            _authenticationService = authenticationService;
        }

        // GET /Problem
        public virtual ActionResult Index()
        {
            return RedirectToAction(MathHub.Core.Config.RouteDefaults.DEFAULT_PROBLEM_TAB);
        }

        // GET /Problem/Trending
        public virtual ActionResult Trending()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Mytags
        public virtual ActionResult Mytags()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Unanswered
        public virtual ActionResult Unanswered()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Newest
        public virtual ActionResult Newest()
        {
            IEnumerable<Problem> problems =
                _problemQueryService.GetNewestProblems(
                Constant.DEFAULT_OFFSET, Constant.DEFAULT_PER_PAGE);

            ICollection<PreviewProblemVM> problemVms =
                problems.Select(Mapper.Map<Problem, PreviewProblemVM>).ToList();

            return View("Views/ListAllProblem", problemVms);
        }


        [Authorize]
        [HttpGet]
        // GET /Problem/Create
        public virtual ActionResult Create()
        {
            return View("Views/CreateProblem");
        }

        // POST /Problem/Create
        [Authorize]
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult Create(CreateProblemVM problemVM)
        {
            if (ModelState.IsValid)
            {
                // create new problem
                Problem p = new Problem();
                p.UserId = _authenticationService.GetUserId();
                p.Title = problemVM.Title;
                p.Content = problemVM.Content;
                p.DateCreated = DateTime.Now;
                p.DateModified = DateTime.Now;
                bool res = _problemCommandService.AddProblem(p);
                if (!res)
                {
                    // by some reason. cannot create problem
                    ModelState.AddModelError("create_problem_exception", "This problem cannot be created. Try again later");
                    return View("Views/CreateProblem",problemVM);
                }
                else
                {
                    return Detail(p.Id);
                }
            }
            else
            {
                // if not ModelState valid
                ModelState.AddModelError("model_state_invalid", "Current State is Invalid");
                return View("Views/CreateProblem", problemVM);
            }
        }

        // GET /Problem/Detail/1
        public virtual ActionResult Detail(int id)
        {
            Problem targetProblem = _problemQueryService.GetProblemById(id);

            // Map from Model to ViewModel
            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);

            // problemViewModel.PostVote = tuple;
         
            problemViewModel.CommentPostVm = new CommentPostVM();
            problemViewModel.CommentPostVm.MainPostId = problemViewModel.Id;
            problemViewModel.CommentPostVm.Type = CommentEnum.QUESTION;

            problemViewModel.AnswerPostVm = new AnswerPostVM();
            problemViewModel.AnswerPostVm.MainPostId = problemViewModel.Id;

            problemViewModel.HintPostVm = new HintPostVM();
            problemViewModel.HintPostVm.MainPostId = problemViewModel.Id;

            return View("Views/DetailProblem", problemViewModel);
        }

        [AjaxCallActionFilter]
        public virtual ActionResult Answer(int postId, int offset)
        {
            IEnumerable<Reply> answers = _problemQueryService.GetAllReplies(
                    postId,
                    ReplyEnum.ANSWER,
                    offset,
                    Constant.DEFAULT_PER_PAGE
                ).AsEnumerable();

            ICollection<AnswerItemVM> answerItemVms = answers.Select(Mapper.Map<Reply, AnswerItemVM>).ToList();
            AnswerListVM answerListVm = new AnswerListVM();
            answerListVm.AnswerItemVms = answerItemVms;
            return PartialView("Partials/_AnswerList", answerListVm);
        }

        [AjaxCallActionFilter]
        public virtual ActionResult Hint(int postId, int offset)
        {
            IEnumerable<Reply> hints = _problemQueryService.GetAllReplies(
                    postId,
                    ReplyEnum.HINT,
                    offset,
                    Constant.DEFAULT_PER_PAGE
                ).AsEnumerable();

            // Map list models to list viewmodels with lambda expression 
            ICollection<HintItemVM> hintItemVms = hints.Select(Mapper.Map<Reply, HintItemVM>).ToList();
            HintListVM hintListVm = new HintListVM();
            hintListVm.HintItemVms = hintItemVms;
            return PartialView("Partials/_HintList", hintListVm);
        }

        [AjaxCallActionFilter]
        public virtual ActionResult GetReplyComments(int postId, int offset)
        {
            int limit = offset < 0 ? int.MaxValue : Constant.DEFAULT_COMMENT_LOADING;
            offset = offset < 0 ? Constant.DEFAULT_COMMENT_OFFSET : offset;
            

            IEnumerable<Comment> comments = _problemQueryService.GetAllReplyComments(
                postId,
                offset,
                limit
                );

            // Map list models to list viewmodels with lambda expression 
            ICollection<CommentItemVM> commentItemVms = comments
                .Select(Mapper.Map<Comment, CommentItemVM>)
                //.Each(c => c.Type = Models.CommonVM.CommentEnum.ANSWER)
                .ToList();

            CommentListVM commentListVm = new CommentListVM();

            commentListVm.CommentItemVms = commentItemVms;
            return PartialView("Partials/_CommentList", commentListVm);
        }

        [AjaxCallActionFilter]
        public virtual ActionResult GetQuestionComments(int postId, int offset)
        {
            int limit = offset < 0 ? int.MaxValue : Constant.DEFAULT_COMMENT_LOADING;
            offset = offset < 0 ? Constant.DEFAULT_COMMENT_OFFSET : offset;


            IEnumerable<Comment> comments = _problemQueryService.GetAllMainPostComments(
                postId,
                offset,
                limit
                );

            // Map list models to list viewmodels with lambda expression 
            ICollection<CommentItemVM> commentItemVms = comments.Select(Mapper.Map<Comment, CommentItemVM>).ToList();

            CommentListVM commentListVm = new CommentListVM();

            commentListVm.CommentItemVms = commentItemVms;
            return PartialView("Partials/_CommentList", commentListVm);
        }
        
        [Authorize]
        public virtual ActionResult AddComment(CommentPostVM commentPostVm)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();
                comment.UserId = WebSecurity.CurrentUserId;
                comment.DateCreated = DateTime.Now;
                comment.Content = commentPostVm.Content;

                bool res = false;
                switch (commentPostVm.Type) 
                {
                    case CommentEnum.QUESTION:
                        //comment.MainPostId = commentPostVm.MainPostId;
                        res =  _commentCommandService.AddCommentForPost((int)commentPostVm.MainPostId, comment);
                        break;
                    case CommentEnum.REPLY:
                        //comment.ReplyId = commentPostVm.ReplyId;
                        res = _commentCommandService.AddCommentForReply((int)comment.ReplyId, comment);
                        break;
                    default:
                        return null;
                }
                if (res)
                {
                    CommentItemVM commentItemVm = Mapper.Map<Comment, CommentItemVM>(comment);
                    return PartialView("Partials/_CommentItem", commentItemVm);
                }
                else
                {
                    return null;
                }
            }
            // state is not valid
            return null;
        }

        [Authorize]
        public virtual ActionResult AddAnswer(AnswerPostVM answerPostVm)
        {
            if(ModelState.IsValid)
            {
                Reply reply = new Reply();
                reply.Content = answerPostVm.Content;
                reply.UserId = WebSecurity.CurrentUserId;
                reply.DateCreated = DateTime.Now;
                reply.Type = ReplyEnum.ANSWER;

                bool res =  _problemCommandService.AddReply((int)answerPostVm.MainPostId, reply);
                if (res)
                {
                    AnswerItemVM answerItemVm = Mapper.Map<Reply, AnswerItemVM>(reply);
                    return PartialView("Partials/_AnswerItem", answerItemVm);
                }
                else
                {
                    return null;
                }
            }
            // Model State is not valid
            return null;
        }

        [Authorize]
        public virtual ActionResult AddHint(HintPostVM hintPostVm)
        {
            if (ModelState.IsValid)
            {
                Reply reply = new Reply();
                reply.Content = hintPostVm.Content;
                reply.UserId = WebSecurity.CurrentUserId;
                reply.DateCreated = DateTime.Now;
                reply.Type = ReplyEnum.HINT;

                bool res =  _problemCommandService.AddReply((int)hintPostVm.MainPostId, reply);
                if (res)
                {
                    HintItemVM hintItemVm = Mapper.Map<Reply, HintItemVM>(reply);
                    return PartialView("Partials/_AnswerItem", hintItemVm);
                }
                else
                {
                    return null;
                }
            }
            // Model State is not valid
            return null;
        }
    }
}
