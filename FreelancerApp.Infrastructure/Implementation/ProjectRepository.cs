using FreelancerApp.Infrastructure.GenericRepositories;
using FreelancerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelancerApp.Domain.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace FreelancerApp.Infrastructure.Implementation
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly Context dbContext;

        public ProjectRepository(Context dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IReadOnlyList<Project>> GetAllProjectsAsync( bool IncludeClient, bool includeFreelancer)
        {
            var projects =  dbContext.Projects.AsQueryable();
           if( IncludeClient == true ) projects = projects.Include(x => x.client) ;
           if (includeFreelancer == true) projects = projects.Include(x => x.freelancer);
           return await projects.ToListAsync();
        }

        public async Task<Project> GetProjectByIdAsync(Guid id, bool IncludeClient, bool includeFreelancer)
        {
            var project = dbContext.Projects.AsQueryable();
            if (project is null)
            {
                throw new KeyNotFoundException($"Project with id ={id} is not found");
            }
            if (IncludeClient == true) project = project.Include(x => x.client);
            if (includeFreelancer == true) project = project.Include(x => x.freelancer);


            return await project.FirstOrDefaultAsync(x => x.Id == id);
        }

      
    }
}
