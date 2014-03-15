using AutoMapper;
using MathHub.Core.Config;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using MathHub.Web.CustomAnnotation.ActionFilter;
using MathHub.Web.Models.CommonVM;
using MathHub.Web.Models.ProblemVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using MathHub.Framework.Utils;

namespace MathHub.Web.Controllers
{
    public partial class ProblemController : BaseController
    {
        #region GET
        [AjaxCallActionFilter]
        public virtual ActionResult Answer(int postId, int offset)
        {
            IEnumerable<Reply> answers = _problemQueryService.GetAllReplies(
                    postId,
                    ReplyEnum.ANSWER,
                    offset,
                    Constant.DEFAULT_PER_PAGE
                ).AsEnumerable();

            ICollection<AnswerItemVM> answerItemVms = answers
                .Select(Mapper.Map<Reply, AnswerItemVM>)
                .ToList();

            // this mapping must be have
            // if not. strange error will be appear at AutoMapper
            foreach (AnswerItemVM am in answerItemVms) {
                am.CommentPostVm = new CommentPostVM();
                am.CommentPostVm.ReplyId = am.Id;
                am.CommentPostVm.Type = EnumCommentType.REPLY;
            }

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

            // this mapping must be have
            // if not. strange error will be appear at AutoMapper
            foreach (HintItemVM am in hintItemVms)
            {
                am.CommentPostVm = new CommentPostVM();
                am.CommentPostVm.ReplyId = am.Id;
                am.CommentPostVm.Type = EnumCommentType.REPLY;
            }

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
                //  .ForEach( c => c.Type = Models.CommonVM.EnumCommentType.REPLY);
                .ToList();

            foreach (CommentItemVM cm in commentItemVms)
            {
                cm.Type = Models.CommonVM.EnumCommentType.REPLY;
            }

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

            foreach (CommentItemVM cm in commentItemVms)
            {
                cm.Type = Models.CommonVM.EnumCommentType.QUESTION;
            }

            CommentListVM commentListVm = new CommentListVM();

            commentListVm.CommentItemVms = commentItemVms;
            return PartialView("Partials/_CommentList", commentListVm);
        } 
        #endregion

        #region ADD
        [AjaxCallActionFilter]
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
                    case EnumCommentType.QUESTION:
                        //comment.MainPostId = commentPostVm.MainPostId;
                        res = _commentCommandService.AddCommentForPost((int)commentPostVm.MainPostId, comment);
                        break;
                    case EnumCommentType.REPLY:
                        //comment.ReplyId = commentPostVm.ReplyId;
                        res = _commentCommandService.AddCommentForReply((int)commentPostVm.ReplyId, comment);
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

        [AjaxCallActionFilter]
        [Authorize]
        public virtual ActionResult AddAnswer(AnswerPostVM answerPostVm)
        {
            if (ModelState.IsValid)
            {
                Reply reply = new Reply();
                reply.Content = answerPostVm.Content;
                reply.UserId = WebSecurity.CurrentUserId;
                reply.DateCreated = DateTime.Now;
                reply.Type = ReplyEnum.ANSWER;

                bool res = _problemCommandService.AddReply((int)answerPostVm.MainPostId, reply);
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

        [AjaxCallActionFilter]
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

                bool res = _problemCommandService.AddReply((int)hintPostVm.MainPostId, reply);
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
        #endregion
}