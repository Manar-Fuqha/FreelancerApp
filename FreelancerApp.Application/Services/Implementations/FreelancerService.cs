using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelancerApp.Domain;
using AutoMapper;
using FreelancerApp.Application.Exceptions;

namespace FreelancerApp.Application.Services.Implementations
{
    public class FreelancerService : IFreelancerService
    {
        private readonly IUnitOfWork<Freelancer> unitOfWork;
        private readonly IMapper mapper;

        public FreelancerService(IUnitOfWork<Freelancer> unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<Freelancer> Create(Freelancer freelancer)
        {
           
            return await unitOfWork.FreelancerRepository.CreateAsync( freelancer );
        }

        public async Task Delete(Guid id)
        {
            var getFreelance = await unitOfWork.FreelancerRepository.GetByIdAsync(id);
            if (getFreelance is null)
            {
                throw new NotFoundException($"Freelancer with id = {id} is not found");
            }
            await unitOfWork.FreelancerRepository.DeleteAsync(id);
        }

        public async Task<IReadOnlyList<Freelancer>> GetAllFreelancers()
        {
            return await unitOfWork.FreelancerRepository.GetAllAsync();
            
        }

        public async Task<Freelancer> GetFreelacerById(Guid freelacerId)
        {
            var freelancer = await unitOfWork.FreelancerRepository.GetByIdAsync(freelacerId);
            if(freelancer is null)
            {
                throw new NotFoundException($"Freelancer with id = {freelacerId} is not found");
            }

            return freelancer;
        }

        public async Task Update(Guid id, Freelancer freelancer)
        {
           var getFreelance = await unitOfWork.FreelancerRepository.GetByIdAsync(id);
            if(getFreelance is null)
            {
                throw new NotFoundException($"Freelancer with id = {id} is not found");
            }

            var freelacerMapper = mapper.Map(freelancer , getFreelance);
            await unitOfWork.FreelancerRepository.UpdateAsync(id, freelacerMapper);

        }
    }
}
