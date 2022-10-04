using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorServerCRUD.Data.Entities;
using BlazorServerCRUD.Infrastructure.Models;

namespace BlazorServerCRUD.Infrastructure.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            //Source, Destination
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))                
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))
                .ForMember(dest => dest.PhotoFileName, opt => opt.MapFrom(src => src.PhotoFileName))
                .ForMember(dest => dest.DepartmentId, opt => opt.Ignore())
                .ForMember(dest => dest.StartDate, opt => opt.Ignore())
                .ForMember(dest => dest.Department, opt => opt.Ignore())
                //.ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                //.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                //.ForMember(dest => dest.Department, opt => opt.Ignore())
                ;


            //Source, Destination
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))                
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))                
                .ForMember(dest => dest.PhotoFileName, opt => opt.MapFrom(src => src.PhotoFileName))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DepartmentName))
                //.ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                //.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                //.ForMember(dest => dest.Department, opt => opt.Ignore())
                ;

            //Source, Destination
            CreateMap<AddEmployeeViewModel, Employee>()
                ;

            //Source, Destination
            CreateMap<Employee, AddEmployeeViewModel>()
                ;
        }
    }
}
