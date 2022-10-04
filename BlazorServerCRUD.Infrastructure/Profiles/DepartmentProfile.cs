using AutoMapper;
using BlazorServerCRUD.Data.Entities;
using BlazorServerCRUD.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUD.Infrastructure.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            //Source, Destination
            CreateMap<DepartmentDTO, Department>();

            //Source, Destination
            CreateMap<Department, DepartmentDTO>();
        }
    }
}
