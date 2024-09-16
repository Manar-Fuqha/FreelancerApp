using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.IGenericRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(Guid id ,  T entity);
        Task<string> DeleteAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);

    }
}
