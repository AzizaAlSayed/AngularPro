using AngularPro.Models;
using AngularPro.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.AutoMapper
{

    public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {

                CreateMap<Tasks, TaskVM>().ReverseMap();

                CreateMap<Categories, CategoriesVM>().ReverseMap();

                CreateMap<TasksCategories, TaskCategoriesVM>().ReverseMap();

            }
        }
    }
    