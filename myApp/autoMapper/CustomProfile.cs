using AutoMapper;
using ClassLibrary.Entity;
using appModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApp.autoMapper
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<BlogArticle, BlogViewModels>();
        }
    }
}
