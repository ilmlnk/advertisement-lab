using AdIntegration.Business.Models;
using AdIntegration.Data;
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
            CreateMap<UserRegisterModel, User>();
            CreateMap<UserLoginModel, User>();
            CreateMap<CreateAdvertisementModel, Advertisement>()
                .ForMember(d => d.Author, opt => opt.MapFrom(src => src.User.FirstName + ' ' + src.User.LastName));
            CreateMap<EditAdvertisementModel, Advertisement>();

        }
    }
}
