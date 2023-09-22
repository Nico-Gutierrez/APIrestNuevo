﻿using AutoMapper;
using Entites.Models;
using Shared.DataTransferObjects;

namespace APIrestNuevo
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();
        }
    }
}
