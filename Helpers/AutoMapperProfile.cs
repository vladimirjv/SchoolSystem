using AutoMapper;
using SchoolSystem.DTOs;
using SchoolSystem.Models;

namespace SchoolSystem.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}