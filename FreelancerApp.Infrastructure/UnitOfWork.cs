using FreelancerApp.Domain;
using FreelancerApp.Domain.Abstracts;
using FreelancerApp.Infrastructure.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Infrastructure
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly Context dbContext;

        public UnitOfWork(Context dbContext)
        {
            this.dbContext = dbContext;
            FreelancerRepository = new FreelancerRepository(dbContext);
            ProjectRepository = new ProjectRepository(dbContext);
        }

        public IFreelancerRepository FreelancerRepository {  get;}

        public IProjectRepository ProjectRepository { get; }
    }
}
