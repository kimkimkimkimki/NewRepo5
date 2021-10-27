using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada.Domain.Repository_Interfaces.EfRepositories.Base
{
    public interface IEfBaseRepository<TEntity> where TEntity:class
    {
        Task Create(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Where(Expression<Func<TEntity, bool>> filter);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
