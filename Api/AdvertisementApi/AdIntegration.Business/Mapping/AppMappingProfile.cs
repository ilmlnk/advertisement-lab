using AdIntegration.Data;
using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<RegisterUserDto, User>();
            CreateMap<LoginUserDto, User>();
        }
    }
}
