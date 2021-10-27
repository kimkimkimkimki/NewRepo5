using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Hepsiburada.Infrastructure.Repositories.EfRepositories.Base
{
    public class EfBaseRepository<TEntity> : IEfBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EfBaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
             _dbSet.Remove(entity);
             await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();

        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Where(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }
    }
}
