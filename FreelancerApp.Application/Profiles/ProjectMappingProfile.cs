using AutoMapper;
using FreelancerApp.Domain.DTOs.Projects;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Application.Profiles
{
    public class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {

            CreateMap<Project , CreateProjectRequestDto>().ReverseMap();
            CreateMap<Project, UpdateProjectRequestDto>().ReverseMap();
            CreateMap<Project, ProjectDto>()
     .ForMember(dest => dest.FreelancerName, opt => opt.MapFrom(src => src.freelancer.name))
     .ForMember(dest => dest.FreelancerEmail, opt => opt.MapFrom(src => src.freelancer.email))
     .ForMember(dest => dest.FreelancerSkillSet, opt => opt.MapFrom(src => src.freelancer.skillSet))
     .ForMember(dest => dest.FreelancerHourlyRate, opt => opt.MapFrom(src => src.freelancer.hourlyRate))
     .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.client.name))
     .ForMember(dest => dest.ClientEmail, opt => opt.MapFrom(src => src.client.email))
     .ReverseMap();
        }
    }
}
