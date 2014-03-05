using AutoMapper;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Web.Models.DiscussionVM;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.AutoMapperProfile
{
    public class DiscussionMapperProfile : AutoMapper.Profile
    {
        /// <summary>
        /// Config profile for System AutoMapper
        /// </summary>
        protected override void Configure()
        {
            
            // Comment
            Mapper.CreateMap<Comment, DCommentItemVM>();
            
            // Discussion
            Mapper.CreateMap<Discussion, PreviewDiscussionVM>();

            Mapper.CreateMap<Discussion, DetailDiscussionVM>()
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
        }
    }
}