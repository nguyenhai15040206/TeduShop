using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config => {
                config.CreateMap<Post, PostViewModel>();
                config.CreateMap<PostCategory, PostCategoryViewModel>();
                config.CreateMap<Tag, TagViewModel>();
                config.CreateMap<PostTag, PostTagViewModel>();
            });
        }
    }
}