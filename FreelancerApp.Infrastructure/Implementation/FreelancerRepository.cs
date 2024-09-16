using FreelancerApp.Domain.Abstracts;
using FreelancerApp.Domain.Models;
using FreelancerApp.Infrastructure.GenericRepositories;


namespace FreelancerApp.Infrastructure.Implementation
{
    partial class FreelancerRepository : GenericRepository<Freelancer>, IFreelancerRepository
    {
        public FreelancerRepository(Context dbContext) : base(dbContext)
        {
        }

        
    }
}
