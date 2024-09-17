using AutoMapper;
using FreelancerApp.Domain.DTOs.Freelancers;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Application.Profiles
{
    public class FreelancerMappingProfile : Profile
    {
        public FreelancerMappingProfile()
        {

            CreateMap<Freelancer , CreateFreelancerDto>().ReverseMap();
            CreateMap<Freelancer , UpdateFreelancerRequestDto>().ReverseMap();


        }
    }
}
