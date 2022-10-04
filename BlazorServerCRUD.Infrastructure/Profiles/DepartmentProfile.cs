using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorServerCRUD.Data.Entities;
using BlazorServerCRUD.Infrastructure.Models;

namespace BlazorServerCRUD.Infrastructure.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            //Source, Destination
            CreateMap<DepartmentViewModel, Department>();

            //Source, Destination
            CreateMap<Department, DepartmentViewModel>();
        }
    }
}
