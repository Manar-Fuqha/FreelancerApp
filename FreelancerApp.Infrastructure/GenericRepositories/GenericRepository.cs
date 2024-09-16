using FreelancerApp.Domain.IGenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Infrastructure.GenericRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context dbContext;

        public GenericRepository(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("The entity is null");
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<string> DeleteAsync(Guid id)
        {
            var entity = await dbContext.Set<T>().FindAsync(id);
            if (entity is null )
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
            return "Deleted Successfully";
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
          return  await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await dbContext.Set<T>().FindAsync(id);
            if (entity is null)
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }
            return entity;
        }

        public async Task<T> UpdateAsync(Guid id, T entity)
        {
            var Foundentity = await dbContext.Set<T>().FindAsync(id);
            if (Foundentity is null)
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }

            dbContext.Entry(Foundentity).CurrentValues.SetValues(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
