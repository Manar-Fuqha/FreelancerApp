using FreelancerApp.Application.Exceptions;
using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Domain;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork<Project> unitOfWork;

        public ProjectService(IUnitOfWork<Project> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Project> Create(Project project)
        {
           //if(project is null)
           // {
           //     // 
           // }
           return await unitOfWork.ProjectRepository.CreateAsync(project);

        }

        public async Task Delete(Guid id)
        {
            var getProject = await unitOfWork.ProjectRepository.GetByIdAsync(id);
            if(getProject is null)
            {
                throw new NotFoundException($"Proect with id = {id} is not found");
            }
            await unitOfWork.ProjectRepository.DeleteAsync(id);
        }

        public async Task<IReadOnlyList<Project>> GetAllProjects( bool includeClient, bool includeFreelance)
        {
            return await unitOfWork.ProjectRepository.GetAllProjectsAsync(includeClient, includeFreelance);
        }

        public async Task<Project> GetProjectById(Guid ProjectId , bool includeClient , bool includeFreelance)
        {
            var getProject = await unitOfWork.ProjectRepository.GetProjectByIdAsync(ProjectId  , includeClient , includeFreelance);
            if(getProject is null)
            {
                throw new NotFoundException($"Proect with id = {ProjectId} is not found");
            }
            return getProject;
        }

        public async Task Update(Guid id, Project project)
        {
            var getProject = await unitOfWork.ProjectRepository.GetByIdAsync(id);
            if (getProject is null)
            {
                throw new NotFoundException($"Proect with id = {id} is not found");
            }
            await unitOfWork.ProjectRepository.UpdateAsync(id, project);
        }
    }
}
