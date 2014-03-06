using AutoMapper;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Web.Models.CommonVM;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.AutoMapperProfile
{
    public class CommonMapperProfile : AutoMapper.Profile
    {
        /// <summary>
        /// Config profile for System AutoMapper
        /// </summary>
        protected override void Configure()
        {
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
        }
    }
}