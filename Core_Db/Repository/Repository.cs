using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using PSafe.Core.SharedKernel;

namespace PSafe.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            if (_context != null)
            {
                _dbSet = _context.Set<TEntity>();
            }
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().AsEnumerable().ToList();
        }
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).AsNoTracking().ToList();
            }
            else
            {
                return query.AsNoTracking().ToList();
            }
        }

        public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking().AsEnumerable().ToList();
        }

        public virtual TEntity GetById(object id)
        {
            if (id == null)
                throw new ArgumentNullException("id");
            return _dbSet.Find(id);
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking().SingleOrDefault();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            var newEntity = _dbSet.Add(entity).Entity;
            return newEntity;
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            if (entityToUpdate == null)
                throw new ArgumentNullException("entityToUpdate");
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            this.Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (entityToDelete == null)
                throw new ArgumentNullException("entityToDelete");
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            var entityToDelete = _dbSet.Where(filter).FirstOrDefault();
            this.Delete(entityToDelete);
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity Last()
        {
            return _dbSet.AsNoTracking().Last();
        }
    }
}
