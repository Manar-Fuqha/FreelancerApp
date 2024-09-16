using FreelancerApp.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain
{
    public interface IUnitOfWork<T> where T : class
    {
        public IFreelancerRepository FreelancerRepository { get; }
        public IProjectRepository ProjectRepository { get; }
    }
}
