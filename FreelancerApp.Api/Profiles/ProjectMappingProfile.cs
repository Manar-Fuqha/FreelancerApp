using AutoMapper;
using FreelancerApp.Domain.DTOs.Projects;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Api.Profiles
{
    public class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {

            CreateMap<Project , CreateProjectRequestDto>().ReverseMap();
            CreateMap<Project, UpdateProjectRequestDto>().ReverseMap();

        }
    }
}
