using AdIntegration.Data.Dto.UserDto;
using AdIntegration.Data.Entities;
using AutoMapper;

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
