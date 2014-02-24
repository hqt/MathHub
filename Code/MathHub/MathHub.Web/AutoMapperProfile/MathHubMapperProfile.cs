﻿using System.Linq;
using AutoMapper;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Web.Models.CommonVM;
using MathHub.Web.Models.ProblemVM;
using Profile = AutoMapper.Profile;

namespace MathHub.Web.AutoMapperProfile
{
    class MathHubMapperProfile : Profile
    {
        /// <summary>
        /// Config profile for System AutoMapper
        /// </summary>
        protected override void Configure()
        {
            
            // Comment
            Mapper.CreateMap<Comment, CommentItemVM>();

            // Profile
            Mapper.CreateMap<User, ProfileWidgetVM>()
                .ForMember(p => p.Medal,
                    m => m.MapFrom(
                    s => ((IUserQueryService)null).GetMedals(s.Id)
                ))
                .ForMember(p => p.Avatar,
                    m => m.MapFrom(
                    s => ((IUserQueryService)null).GetLoginUserAvatar()
                ));
            
            // Problem
            Mapper.CreateMap<Problem, PreviewProblemVM>();
            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(p => p.VoteUpNum,
                    m => m.MapFrom(
                    s => ((IProblemQueryService)null).GetPostVoteUp(s.Id)
                ))
                .ForMember(p => p.VoteDownNum,
                    m => m.MapFrom(
                    s => ((IProblemQueryService)null).GetPostVoteDown(s.Id)
                ));

            // Reply
            Mapper.CreateMap<Reply, AnswerItemVM>();
            Mapper.CreateMap<Reply, HintItemVM>();
        }
    }
}
