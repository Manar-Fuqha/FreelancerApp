using FreelancerApp.Domain.Models;
using FreelancerApp.Domain.IGenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.Abstracts
{
    public interface IProjectRepository :IGenericRepository<Project>
    {
        Task<Project> GetProjectByIdAsync(Guid id, bool IncludeClient, bool includeFreelancer);
        Task<IReadOnlyList<Project>> GetAllProjectsAsync( bool IncludeClient, bool includeFreelancer);
    }
}
