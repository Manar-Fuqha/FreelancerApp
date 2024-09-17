using FreelancerApp.Domain.DTOs.Projects;
using FreelancerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Application.Services.Abstracts
{
    public interface IProjectService
    {
        Task<Project> GetProjectById(Guid ProjectId, bool includeClient, bool includeFreelance);
        Task<IReadOnlyList<Project>> GetAllProjects( bool includeClient, bool includeFreelance);
        Task<Project> Create(CreateProjectRequestDto project);
        Task Update(Guid id, UpdateProjectRequestDto project);
        Task Delete(Guid id);
    }
}
