﻿using System.Linq;
using AutoMapper;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Framework.Infrastructure.Repository;
using MathHub.Service.Problems;
using MathHub.Web.Models.CommonVM;
using MathHub.Web.Models.ProblemVM;
using Profile = AutoMapper.Profile;
using MathHub.Framework.Infrastructure.AutoMapper;
using System;

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

<<<<<<< HEAD
            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(
                    p => p.PostVote,
                    m => m
                        //.MapFrom(s => ((IProblemQueryService)null).GetPostVote(s.Id))
                        .ResolveUsing<TupleMapperResolver.DoubleTuple>()
                        //.FromMember(s => new Tuple<int, int>(10, 10))
                        .FromMember(s => ((IProblemQueryService)null).GetPostVote(s.Id))
                )
                .ForMember(p => p.PostSocial,
                    //m => m.MapFrom(
                    //s => ((IProblemQueryService)null).GetPostSocialReport(s.Id)
                    m => m
                        //.MapFrom(s => ((IProblemQueryService)null).GetPostVote(s.Id))
                        .ResolveUsing<TupleMapperResolver.TripleTuple>()
                        //.FromMember(s => new Tuple<int, int, int>(10, 10, 10))
                        .FromMember(s => ((IProblemQueryService)null).GetPostSocialReport(s.Id))
                )
                .ForMember(p => p.PostReply,
                    //m => m.MapFrom(
                    //s => ((IProblemQueryService)null).GetPostReplyReport(s.Id)
                        //m => m.MapFrom(
                    //s => ((IProblemQueryService)null).GetPostSocialReport(s.Id)
                    m => m
                        //.MapFrom(s => ((IProblemQueryService)null).GetPostVote(s.Id))
                        .ResolveUsing<TupleMapperResolver.TripleTuple>()
                        //.FromMember(s => new Tuple<int, int, int>(10, 10, 10))
                       .FromMember(s => ((IProblemQueryService)null).GetPostReplyReport(s.Id))
                );
=======
            //Mapper.CreateMap<Problem, DetailProblemVM>()
            //    .ForMember(
            //        p => p.PostVote,
            //        m => m
            //            //.MapFrom(s => ((IProblemQueryService)null).GetPostVote(s.Id))
            //            .ResolveUsing<TupleMapperResolver.DoubleTuple>()
            //            //.FromMember(s => new Tuple<int, int>(10, 10))
            //            .FromMember(s => ((IProblemQueryService)null).GetPostVote(s.Id))
            //    );
                //.ForMember(p => p.PostSocial,
                //    m => m.MapFrom(
                //    s => ((IProblemQueryService)null).GetPostSocialReport(s.Id)
                //))
                //.ForMember(p => p.PostReply,
                //    m => m.MapFrom(
                //    s => ((IProblemQueryService)null).GetPostReplyReport(s.Id)
                //)
>>>>>>> 7541e77590a77c2d69ec7a40878e99d02e453011

            // Reply
            Mapper.CreateMap<Reply, AnswerItemVM>();
            Mapper.CreateMap<Reply, HintItemVM>();
        }
    }
}
