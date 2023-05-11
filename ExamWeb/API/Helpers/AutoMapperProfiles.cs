using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>();
            CreateMap<Exam, ExamDTO>();
            CreateMap<Subject, SubjectDTO>();
            CreateMap<MemberUpdateDTO, AppUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName.ToLower().Replace(" ","_")));
        }
    }
}