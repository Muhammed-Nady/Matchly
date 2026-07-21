using AutoMapper;
using Matchly.DTOs;
using Matchly.Entities;
using Matchly.Extensions;

namespace Matchly.Helpers
{
    public class AutoMapperProfiles : Profile  
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.MainPhotoUrl, opt => opt.MapFrom(user => user.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(user => user.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
        }
    }
}
