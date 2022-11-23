using AutoMapper;
using KomdekaAPI.Entities.DataTransferObjects;
using KomdekaAPI.Entities.Models;

namespace KomdekaAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
