using System.Linq;
using AutoMapper;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Web.Models.CommonVM;
using MathHub.Web.Models.ProblemVM;
using Profile = AutoMapper.Profile;
using MathHub.Framework.Infrastructure.AutoMapper;
using System;
using StructureMap;

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

            // Problem
            Mapper.CreateMap<Problem, PreviewProblemVM>();

            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(
                    p => p.PostVote,
                    m => m
                        .MapFrom(s => (ObjectFactory.GetInstance<IProblemQueryService>()).GetPostVote(s.Id))
                )
                .ForMember(p => p.PostSocial,
                    m => m.MapFrom(
                    s => (ObjectFactory.GetInstance<IProblemQueryService>()).GetPostSocialReport(s.Id)
                ))
                .ForMember(p => p.PostReply,
                    m => m.MapFrom(
                    s => (ObjectFactory.GetInstance<IProblemQueryService>()).GetPostReplyReport(s.Id)
                ));

            // Profile
            Mapper.CreateMap<User, ProfileWidgetVM>()
                .ForMember(p => p.Medal,
                    m => m.MapFrom(
                    s => (ObjectFactory.GetInstance<IUserQueryService>()).GetUserMedals(s.Id)
                ))
                .ForMember(p => p.Avatar,
                    m => m.MapFrom(
                    s => (ObjectFactory.GetInstance<IUserQueryService>()).GetLoginAvatar()
                ));

            // Reply
            Mapper.CreateMap<Reply, AnswerItemVM>();
            Mapper.CreateMap<Reply, HintItemVM>();
        }
    }
}
