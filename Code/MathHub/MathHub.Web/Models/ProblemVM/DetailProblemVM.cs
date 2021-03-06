﻿using System.Collections.Generic;
using System;
using MathHub.Entity.Entity;
using MathHub.Web.Models.CommonVM;

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

        public Tuple<int, int> PostVote { get; set; }
        /// <summary>
        /// favorite - report - share
        /// </summary>
        public Tuple<int, int, int> PostSocial { get; set; }
        /// <summary>
        ///  comment - answer - hint 
        /// </summary>
        public Tuple<int, int, int> PostReply { get; set; }       

        //public CommentListVM Comments { get; set; }
        public CommentPostVM CommentPostVm { get; set; }
        public AnswerPostVM AnswerPostVm { get; set; }
        public HintPostVM HintPostVm { get; set; }
        public UserInfoVM UserInfo { get; set; }

    }
}