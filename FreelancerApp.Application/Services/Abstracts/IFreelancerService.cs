using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Application.Services.Abstracts
{
    public interface IFreelancerService
    {
        Task<Freelancer> GetFreelacerById (Guid freelacerId);
        Task<IReadOnlyList<Freelancer>> GetAllFreelancers();
        Task<Freelancer> Create(Freelancer freelancer);
        Task Update(Guid id,Freelancer freelancer);
        Task Delete(Guid id);
    }
}
