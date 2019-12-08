using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CodeWars.Core.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<int> Count();
        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        Task AddAsync(TEntity entity);
        void Delete(TEntity entity);
        void DeleteMany(IEnumerable<TEntity> entities);
        void DeleteById(object id);
        void Update(TEntity entity);
    }
}
