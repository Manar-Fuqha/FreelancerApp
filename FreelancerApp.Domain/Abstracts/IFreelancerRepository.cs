using FreelancerApp.Domain.IGenericRepositories;
using FreelancerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.Abstracts
{
    public interface IFreelancerRepository :IGenericRepository<Freelancer>
    {
    }
}
