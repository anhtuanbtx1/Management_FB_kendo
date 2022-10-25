using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PSafe.Core.SharedKernel
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity GetOne(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(object id);

        TEntity Last();
        TEntity Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(TEntity entityToDelete);
        void Delete(Expression<Func<TEntity, bool>> filter);
        int SaveChanges();
    }
}
